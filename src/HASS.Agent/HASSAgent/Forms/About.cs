﻿using Syncfusion.Windows.Forms;
using System;
using HASSAgent.Functions;

namespace HASSAgent.Forms
{
    public partial class About : MetroForm
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e) => LblVersion.Text = Variables.Version;

        private void LblCoreAudio_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://github.com/morphx666/CoreAudio");

        private void LblGrapevine_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://scottoffen.github.io/grapevine/");

        private void LblHADotNet_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://github.com/qJake/HADotNet");

        private void LblHotkeyListener_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://github.com/Willy-Kimura/HotkeyListener");

        private void LblLibreHardwareMonitor_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://github.com/LibreHardwareMonitor/LibreHardwareMonitor");

        private void LblMicrosoftToolkitUwpNotifications_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://github.com/CommunityToolkit/WindowsCommunityToolkit");

        private void LblMQTTnet_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://github.com/chkr1011/MQTTnet");

        private void LblNewtonsoftJson_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://www.newtonsoft.com/json");

        private void LblSerilog_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://github.com/serilog/serilog");

        private void LblSyncfusion_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://www.syncfusion.com/");

        private void LblTaskScheduler_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://github.com/dahall/taskscheduler");

        private void LblHassAgentProject_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://github.com/LAB02-Research/HASS.Agent");

        private void PbHassAgentLogo_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://github.com/LAB02-Research/HASS.Agent");

        private void PbHassLogo_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://www.home-assistant.io");

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void LblLab02Research_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://lab02-research.org");

        private void LblCoderr_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://coderr.io");

        private void LblOctokit_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://github.com/octokit/octokit.net");

        private void LblCliWrap_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://github.com/Tyrrrz/CliWrap");
    }
}
