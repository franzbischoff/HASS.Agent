﻿using System;
using System.Collections.Generic;
using System.IO;
using HASSAgent.Enums;
using HASSAgent.Models;
using HASSAgent.Models.Config;
using HASSAgent.Models.HomeAssistant.Commands;
using HASSAgent.Models.HomeAssistant.Sensors;
using HASSAgent.Models.Internal;
using Newtonsoft.Json;
using Serilog;
using WK.Libraries.HotkeyListenerNS;

namespace HASSAgent.Settings
{
    /// <summary>
    /// Handles loading and storing objects and settings
    /// </summary>
    internal class SettingsManager
    {
        /// <summary>
        /// Load all stored settings and objects
        /// </summary>
        /// <returns></returns>
        internal static bool Load()
        {
            Log.Information("[SETTINGS] Config storage path: {path}", Variables.ConfigPath);

            // check config dir
            if (!Directory.Exists(Variables.ConfigPath))
            {
                // create dir
                Directory.CreateDirectory(Variables.ConfigPath);

                // create default config
                StoreInitialSettings();

                // set onboarding
                Variables.AppSettings.OnboardingStatus = OnboardingStatus.NeverDone;

                // done
                return true;
            }

            var allGood = true;

            // load app settings
            var ok = LoadAppSettings();
            if (!ok) allGood = false;

            // load quick actions
            ok = StoredQuickActions.Load();
            if (!ok) allGood = false;

            // load commands
            ok = StoredCommands.Load();
            if (!ok) allGood = false;

            // load sensors
            ok = StoredSensors.Load();
            if (!ok) allGood = false;

            // done
            return allGood;
        }

        /// <summary>
        /// Load stored application settings
        /// </summary>
        /// <returns></returns>
        private static bool LoadAppSettings()
        {
            try
            {
                if (!File.Exists(Variables.AppSettingsFile))
                {
                    // store default settings
                    StoreInitialSettings();

                    // set onboarding
                    Variables.AppSettings.OnboardingStatus = OnboardingStatus.NeverDone;

                    // done
                    return true;
                }

                var appSettingsRaw = File.ReadAllText(Variables.AppSettingsFile);
                if (string.IsNullOrWhiteSpace(appSettingsRaw)) return true;

                // get the global settings
                Variables.AppSettings = JsonConvert.DeserializeObject<AppSettings>(appSettingsRaw);
                if (Variables.AppSettings == null)
                {
                    // something went wrong, but we're not saving new ones, user might want to recover values
                    Log.Error("[SETTINGS] Error loading settings: returned null object");
                    return false;
                }

                // fix onboarding status for backwards compat.
                if (Variables.AppSettings.OnboardingStatus == OnboardingStatus.NeverDone)
                {
                    Variables.AppSettings.OnboardingStatus = OnboardingStatus.Completed;
                    StoreAppSettings();
                }

                // load the hotkey
                Variables.QuickActionsHotKey = string.IsNullOrEmpty(Variables.AppSettings.QuickActionsHotKey) ? null : HotkeyListener.Convert(Variables.AppSettings.QuickActionsHotKey);

                // done
                Log.Information("[SETTINGS] Configuration loaded");
                return true;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "[SETTINGS] Error loading app settings: {err}", ex.Message);
                Variables.MainForm?.ShowMessageBox($"Error loading settings:\r\n\r\n{ex.Message}", true);
                return false;
            }
        }

        /// <summary>
        /// Store default settings
        /// </summary>
        /// <returns></returns>
        private static bool StoreInitialSettings()
        {
            try
            {
                Log.Information("[SETTINGS] No config found, storing default settings");
                
                // empty collections
                Variables.QuickActions = new List<QuickAction>();
                Variables.Commands = new List<AbstractCommand>();
                Variables.SingleValueSensors = new List<AbstractSingleValueSensor>();

                // default settings
                Variables.AppSettings = new AppSettings();

                // store default
                var appSettings = JsonConvert.SerializeObject(Variables.AppSettings, Formatting.Indented);
                File.WriteAllText(Variables.AppSettingsFile, appSettings);
                return true;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "[SETTINGS] Error storing initial settings: {err}", ex.Message);
                Variables.MainForm?.ShowMessageBox($"Error storing initial settings:\r\n\r\n{ex.Message}", true);
                return false;
            }
        }

        /// <summary>
        /// Store all settings and objects
        /// </summary>
        /// <returns></returns>
        internal static bool Store()
        {
            // check config dir
            if (!Directory.Exists(Variables.ConfigPath))
            {
                // create
                Directory.CreateDirectory(Variables.ConfigPath);
            }

            // start positive
            var allGood = true;

            // store app settings
            var ok = StoreAppSettings();
            if (!ok) allGood = false;

            // store quick settings
            ok = StoredQuickActions.Store();
            if (!ok) allGood = false;

            // store commands
            ok = StoredCommands.Store();
            if (!ok) allGood = false;

            // store sensors
            ok = StoredSensors.Store();
            if (!ok) allGood = false;

            // done
            return allGood;
        }

        /// <summary>
        /// Store current application settings
        /// </summary>
        /// <returns></returns>
        internal static bool StoreAppSettings()
        {
            try
            {
                // serialize to file
                var appSettings = JsonConvert.SerializeObject(Variables.AppSettings, Formatting.Indented);
                File.WriteAllText(Variables.AppSettingsFile, appSettings);

                // done
                Log.Information("[SETTINGS] Configuration stored");
                return true;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "[SETTINGS] Error storing app settings: {err}", ex.Message);
                Variables.MainForm?.ShowMessageBox($"Error storing settings:\r\n\r\n{ex.Message}", true);
                return false;
            }
        }
    }
}
