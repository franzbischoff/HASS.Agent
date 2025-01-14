﻿namespace HASSAgent.Forms.QuickActions
{
    partial class QuickActionsMod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickActionsMod));
            this.BtnStore = new Syncfusion.WinForms.Controls.SfButton();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.CbAction = new System.Windows.Forms.ComboBox();
            this.CbEntity = new System.Windows.Forms.ComboBox();
            this.CbDomain = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblLoading = new System.Windows.Forms.Label();
            this.LblEntity = new System.Windows.Forms.Label();
            this.TbHotkey = new System.Windows.Forms.TextBox();
            this.CbEnableHotkey = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnStore
            // 
            this.BtnStore.AccessibleName = "Button";
            this.BtnStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.BtnStore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnStore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.BtnStore.Location = new System.Drawing.Point(0, 440);
            this.BtnStore.Name = "BtnStore";
            this.BtnStore.Size = new System.Drawing.Size(352, 38);
            this.BtnStore.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.BtnStore.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.BtnStore.Style.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.BtnStore.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.BtnStore.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.BtnStore.Style.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.BtnStore.Style.PressedForeColor = System.Drawing.Color.Black;
            this.BtnStore.TabIndex = 4;
            this.BtnStore.Text = "store quick action";
            this.BtnStore.UseVisualStyleBackColor = false;
            this.BtnStore.Click += new System.EventHandler(this.BtnStore_Click);
            // 
            // TbDescription
            // 
            this.TbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.TbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TbDescription.Location = new System.Drawing.Point(12, 291);
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(328, 25);
            this.TbDescription.TabIndex = 3;
            // 
            // CbAction
            // 
            this.CbAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.CbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.CbAction.FormattingEnabled = true;
            this.CbAction.Location = new System.Drawing.Point(12, 229);
            this.CbAction.Name = "CbAction";
            this.CbAction.Size = new System.Drawing.Size(139, 25);
            this.CbAction.TabIndex = 2;
            // 
            // CbEntity
            // 
            this.CbEntity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.CbEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEntity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEntity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.CbEntity.FormattingEnabled = true;
            this.CbEntity.Location = new System.Drawing.Point(12, 99);
            this.CbEntity.Name = "CbEntity";
            this.CbEntity.Size = new System.Drawing.Size(328, 25);
            this.CbEntity.TabIndex = 1;
            this.CbEntity.SelectedIndexChanged += new System.EventHandler(this.CbEntity_SelectedIndexChanged);
            // 
            // CbDomain
            // 
            this.CbDomain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.CbDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDomain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbDomain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.CbDomain.FormattingEnabled = true;
            this.CbDomain.Location = new System.Drawing.Point(12, 39);
            this.CbDomain.Name = "CbDomain";
            this.CbDomain.Size = new System.Drawing.Size(328, 25);
            this.CbDomain.TabIndex = 0;
            this.CbDomain.SelectedIndexChanged += new System.EventHandler(this.CbDomain_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "domain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "entity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "action";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "description (optional, will be used instead of entity name)";
            // 
            // LblLoading
            // 
            this.LblLoading.AutoSize = true;
            this.LblLoading.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoading.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.LblLoading.Location = new System.Drawing.Point(44, 407);
            this.LblLoading.Name = "LblLoading";
            this.LblLoading.Size = new System.Drawing.Size(264, 17);
            this.LblLoading.TabIndex = 7;
            this.LblLoading.Text = "please wait while your entities are fetched ...";
            this.LblLoading.Visible = false;
            // 
            // LblEntity
            // 
            this.LblEntity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblEntity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEntity.Location = new System.Drawing.Point(12, 127);
            this.LblEntity.Name = "LblEntity";
            this.LblEntity.Size = new System.Drawing.Size(328, 69);
            this.LblEntity.TabIndex = 15;
            // 
            // TbHotkey
            // 
            this.TbHotkey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.TbHotkey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbHotkey.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbHotkey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TbHotkey.Location = new System.Drawing.Point(179, 339);
            this.TbHotkey.Name = "TbHotkey";
            this.TbHotkey.Size = new System.Drawing.Size(161, 25);
            this.TbHotkey.TabIndex = 18;
            this.TbHotkey.TextChanged += new System.EventHandler(this.TbHotkey_TextChanged);
            // 
            // CbEnableHotkey
            // 
            this.CbEnableHotkey.AutoSize = true;
            this.CbEnableHotkey.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEnableHotkey.Location = new System.Drawing.Point(179, 370);
            this.CbEnableHotkey.Name = "CbEnableHotkey";
            this.CbEnableHotkey.Size = new System.Drawing.Size(108, 21);
            this.CbEnableHotkey.TabIndex = 17;
            this.CbEnableHotkey.Text = "enable hotkey";
            this.CbEnableHotkey.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "hotkey combination:";
            // 
            // QuickActionsMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(352, 478);
            this.Controls.Add(this.TbHotkey);
            this.Controls.Add(this.CbEnableHotkey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblEntity);
            this.Controls.Add(this.TbDescription);
            this.Controls.Add(this.CbAction);
            this.Controls.Add(this.LblLoading);
            this.Controls.Add(this.CbEntity);
            this.Controls.Add(this.BtnStore);
            this.Controls.Add(this.CbDomain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(131)))));
            this.Name = "QuickActionsMod";
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Action";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuickActionsMod_FormClosing);
            this.Load += new System.EventHandler(this.QuickActionsMod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.Controls.SfButton BtnStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblLoading;
        private System.Windows.Forms.ComboBox CbDomain;
        private System.Windows.Forms.ComboBox CbEntity;
        private System.Windows.Forms.ComboBox CbAction;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.Label LblEntity;
        private System.Windows.Forms.TextBox TbHotkey;
        private System.Windows.Forms.CheckBox CbEnableHotkey;
        private System.Windows.Forms.Label label5;
    }
}

