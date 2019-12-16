namespace Windows_Assistant
{
    partial class UI
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
            this.StopButton = new System.Windows.Forms.Button();
            this.TextOutput = new System.Windows.Forms.TextBox();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.ActivateButton = new System.Windows.Forms.Button();
            this.BedroomLightsOnButton = new System.Windows.Forms.Button();
            this.BedroomLightsOffButton = new System.Windows.Forms.Button();
            this.HeaterOnButton = new System.Windows.Forms.Button();
            this.HeaterOffButton = new System.Windows.Forms.Button();
            this.BathroomLightsOnButton = new System.Windows.Forms.Button();
            this.BathroomLightsOffButton = new System.Windows.Forms.Button();
            this.PlaybarVolumeUpButton = new System.Windows.Forms.Button();
            this.PlaybarVolumeDownButton = new System.Windows.Forms.Button();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.WindowsTab = new System.Windows.Forms.TabPage();
            this.BedroomTab = new System.Windows.Forms.TabPage();
            this.LivingRoomTab = new System.Windows.Forms.TabPage();
            this.BathroomTab = new System.Windows.Forms.TabPage();
            this.HouseTab = new System.Windows.Forms.TabPage();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.checkRunOnStart = new System.Windows.Forms.CheckBox();
            this.checkPrintResults = new System.Windows.Forms.CheckBox();
            this.MainTabControl.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.ForeColor = System.Drawing.Color.Red;
            this.StopButton.Location = new System.Drawing.Point(525, 9);
            this.StopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(114, 45);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Exit";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TextOutput
            // 
            this.TextOutput.HideSelection = false;
            this.TextOutput.Location = new System.Drawing.Point(3, 59);
            this.TextOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextOutput.Multiline = true;
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.ReadOnly = true;
            this.TextOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextOutput.Size = new System.Drawing.Size(394, 254);
            this.TextOutput.TabIndex = 2;
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(3, 9);
            this.TextInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextInput.Multiline = true;
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(394, 44);
            this.TextInput.TabIndex = 3;
            this.TextInput.TextChanged += new System.EventHandler(this.TextInput_TextChanged);
            // 
            // ActivateButton
            // 
            this.ActivateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.ActivateButton.Location = new System.Drawing.Point(405, 9);
            this.ActivateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActivateButton.Name = "ActivateButton";
            this.ActivateButton.Size = new System.Drawing.Size(114, 45);
            this.ActivateButton.TabIndex = 4;
            this.ActivateButton.Text = "Activate";
            this.ActivateButton.UseVisualStyleBackColor = true;
            this.ActivateButton.Click += new System.EventHandler(this.ActivateButton_Click);
            // 
            // BedroomLightsOnButton
            // 
            this.BedroomLightsOnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedroomLightsOnButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BedroomLightsOnButton.Location = new System.Drawing.Point(405, 59);
            this.BedroomLightsOnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BedroomLightsOnButton.Name = "BedroomLightsOnButton";
            this.BedroomLightsOnButton.Size = new System.Drawing.Size(114, 60);
            this.BedroomLightsOnButton.TabIndex = 5;
            this.BedroomLightsOnButton.Text = "Bedroom Lights On";
            this.BedroomLightsOnButton.UseVisualStyleBackColor = true;
            this.BedroomLightsOnButton.Click += new System.EventHandler(this.BedroomLightsOnButton_Click);
            // 
            // BedroomLightsOffButton
            // 
            this.BedroomLightsOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedroomLightsOffButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BedroomLightsOffButton.Location = new System.Drawing.Point(525, 59);
            this.BedroomLightsOffButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BedroomLightsOffButton.Name = "BedroomLightsOffButton";
            this.BedroomLightsOffButton.Size = new System.Drawing.Size(114, 60);
            this.BedroomLightsOffButton.TabIndex = 15;
            this.BedroomLightsOffButton.Text = "Bedroom Lights Off";
            this.BedroomLightsOffButton.UseVisualStyleBackColor = true;
            this.BedroomLightsOffButton.Click += new System.EventHandler(this.BedroomLightsOffButton_Click);
            // 
            // HeaterOnButton
            // 
            this.HeaterOnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaterOnButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HeaterOnButton.Location = new System.Drawing.Point(405, 124);
            this.HeaterOnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaterOnButton.Name = "HeaterOnButton";
            this.HeaterOnButton.Size = new System.Drawing.Size(114, 60);
            this.HeaterOnButton.TabIndex = 16;
            this.HeaterOnButton.Text = "Heater On";
            this.HeaterOnButton.UseVisualStyleBackColor = true;
            this.HeaterOnButton.Click += new System.EventHandler(this.HeaterOnButton_Click);
            // 
            // HeaterOffButton
            // 
            this.HeaterOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaterOffButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HeaterOffButton.Location = new System.Drawing.Point(525, 124);
            this.HeaterOffButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeaterOffButton.Name = "HeaterOffButton";
            this.HeaterOffButton.Size = new System.Drawing.Size(114, 60);
            this.HeaterOffButton.TabIndex = 17;
            this.HeaterOffButton.Text = "Heater Off";
            this.HeaterOffButton.UseVisualStyleBackColor = true;
            this.HeaterOffButton.Click += new System.EventHandler(this.HeaterOffButton_Click);
            // 
            // BathroomLightsOnButton
            // 
            this.BathroomLightsOnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BathroomLightsOnButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BathroomLightsOnButton.Location = new System.Drawing.Point(405, 189);
            this.BathroomLightsOnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BathroomLightsOnButton.Name = "BathroomLightsOnButton";
            this.BathroomLightsOnButton.Size = new System.Drawing.Size(114, 60);
            this.BathroomLightsOnButton.TabIndex = 18;
            this.BathroomLightsOnButton.Text = "Bathroom Lights On";
            this.BathroomLightsOnButton.UseVisualStyleBackColor = true;
            this.BathroomLightsOnButton.Click += new System.EventHandler(this.BathroomLightsOnButton_Click);
            // 
            // BathroomLightsOffButton
            // 
            this.BathroomLightsOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BathroomLightsOffButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BathroomLightsOffButton.Location = new System.Drawing.Point(525, 189);
            this.BathroomLightsOffButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BathroomLightsOffButton.Name = "BathroomLightsOffButton";
            this.BathroomLightsOffButton.Size = new System.Drawing.Size(114, 60);
            this.BathroomLightsOffButton.TabIndex = 19;
            this.BathroomLightsOffButton.Text = "Bathroom Lights Off";
            this.BathroomLightsOffButton.UseVisualStyleBackColor = true;
            this.BathroomLightsOffButton.Click += new System.EventHandler(this.BathroomLightsOffButton_Click);
            // 
            // PlaybarVolumeUpButton
            // 
            this.PlaybarVolumeUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaybarVolumeUpButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PlaybarVolumeUpButton.Location = new System.Drawing.Point(405, 254);
            this.PlaybarVolumeUpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlaybarVolumeUpButton.Name = "PlaybarVolumeUpButton";
            this.PlaybarVolumeUpButton.Size = new System.Drawing.Size(114, 60);
            this.PlaybarVolumeUpButton.TabIndex = 20;
            this.PlaybarVolumeUpButton.Text = "Playbar Volume Up";
            this.PlaybarVolumeUpButton.UseVisualStyleBackColor = true;
            this.PlaybarVolumeUpButton.Click += new System.EventHandler(this.PlaybarVolumeUpButton_Click);
            // 
            // PlaybarVolumeDownButton
            // 
            this.PlaybarVolumeDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaybarVolumeDownButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PlaybarVolumeDownButton.Location = new System.Drawing.Point(525, 254);
            this.PlaybarVolumeDownButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlaybarVolumeDownButton.Name = "PlaybarVolumeDownButton";
            this.PlaybarVolumeDownButton.Size = new System.Drawing.Size(114, 60);
            this.PlaybarVolumeDownButton.TabIndex = 21;
            this.PlaybarVolumeDownButton.Text = "Playbar Vol Down";
            this.PlaybarVolumeDownButton.UseVisualStyleBackColor = true;
            this.PlaybarVolumeDownButton.Click += new System.EventHandler(this.PlaybarVolumeDownButton_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.MainTab);
            this.MainTabControl.Controls.Add(this.WindowsTab);
            this.MainTabControl.Controls.Add(this.BedroomTab);
            this.MainTabControl.Controls.Add(this.LivingRoomTab);
            this.MainTabControl.Controls.Add(this.BathroomTab);
            this.MainTabControl.Controls.Add(this.HouseTab);
            this.MainTabControl.Controls.Add(this.SettingsTab);
            this.MainTabControl.Location = new System.Drawing.Point(1, 4);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.Padding = new System.Drawing.Point(6, 4);
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(658, 362);
            this.MainTabControl.TabIndex = 22;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.TextInput);
            this.MainTab.Controls.Add(this.PlaybarVolumeDownButton);
            this.MainTab.Controls.Add(this.StopButton);
            this.MainTab.Controls.Add(this.PlaybarVolumeUpButton);
            this.MainTab.Controls.Add(this.TextOutput);
            this.MainTab.Controls.Add(this.BathroomLightsOffButton);
            this.MainTab.Controls.Add(this.ActivateButton);
            this.MainTab.Controls.Add(this.BathroomLightsOnButton);
            this.MainTab.Controls.Add(this.BedroomLightsOnButton);
            this.MainTab.Controls.Add(this.HeaterOffButton);
            this.MainTab.Controls.Add(this.BedroomLightsOffButton);
            this.MainTab.Controls.Add(this.HeaterOnButton);
            this.MainTab.Location = new System.Drawing.Point(4, 31);
            this.MainTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.MainTab.Size = new System.Drawing.Size(650, 327);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "Main";
            this.MainTab.UseVisualStyleBackColor = true;
            // 
            // WindowsTab
            // 
            this.WindowsTab.Location = new System.Drawing.Point(4, 31);
            this.WindowsTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WindowsTab.Name = "WindowsTab";
            this.WindowsTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WindowsTab.Size = new System.Drawing.Size(650, 327);
            this.WindowsTab.TabIndex = 2;
            this.WindowsTab.Text = "Windows";
            this.WindowsTab.UseVisualStyleBackColor = true;
            // 
            // BedroomTab
            // 
            this.BedroomTab.Location = new System.Drawing.Point(4, 31);
            this.BedroomTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BedroomTab.Name = "BedroomTab";
            this.BedroomTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BedroomTab.Size = new System.Drawing.Size(650, 327);
            this.BedroomTab.TabIndex = 1;
            this.BedroomTab.Text = "Bedroom";
            this.BedroomTab.UseVisualStyleBackColor = true;
            // 
            // LivingRoomTab
            // 
            this.LivingRoomTab.Location = new System.Drawing.Point(4, 31);
            this.LivingRoomTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LivingRoomTab.Name = "LivingRoomTab";
            this.LivingRoomTab.Size = new System.Drawing.Size(650, 327);
            this.LivingRoomTab.TabIndex = 4;
            this.LivingRoomTab.Text = "Living Room";
            this.LivingRoomTab.UseVisualStyleBackColor = true;
            // 
            // BathroomTab
            // 
            this.BathroomTab.Location = new System.Drawing.Point(4, 31);
            this.BathroomTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BathroomTab.Name = "BathroomTab";
            this.BathroomTab.Size = new System.Drawing.Size(650, 327);
            this.BathroomTab.TabIndex = 5;
            this.BathroomTab.Text = "Bathroom";
            this.BathroomTab.UseVisualStyleBackColor = true;
            // 
            // HouseTab
            // 
            this.HouseTab.Location = new System.Drawing.Point(4, 31);
            this.HouseTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HouseTab.Name = "HouseTab";
            this.HouseTab.Size = new System.Drawing.Size(650, 327);
            this.HouseTab.TabIndex = 3;
            this.HouseTab.Text = "House";
            this.HouseTab.UseVisualStyleBackColor = true;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.checkPrintResults);
            this.SettingsTab.Controls.Add(this.checkRunOnStart);
            this.SettingsTab.Location = new System.Drawing.Point(4, 31);
            this.SettingsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingsTab.Size = new System.Drawing.Size(650, 327);
            this.SettingsTab.TabIndex = 6;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // checkRunOnStart
            // 
            this.checkRunOnStart.AutoSize = true;
            this.checkRunOnStart.Location = new System.Drawing.Point(8, 8);
            this.checkRunOnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkRunOnStart.Name = "checkRunOnStart";
            this.checkRunOnStart.Size = new System.Drawing.Size(141, 24);
            this.checkRunOnStart.TabIndex = 0;
            this.checkRunOnStart.Text = "Run on startup";
            this.checkRunOnStart.UseVisualStyleBackColor = true;
            this.checkRunOnStart.CheckedChanged += new System.EventHandler(this.checkRunOnStart_CheckedChanged);
            // 
            // checkPrintResults
            // 
            this.checkPrintResults.AutoSize = true;
            this.checkPrintResults.Location = new System.Drawing.Point(8, 36);
            this.checkPrintResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkPrintResults.Name = "checkPrintResults";
            this.checkPrintResults.Size = new System.Drawing.Size(162, 24);
            this.checkPrintResults.TabIndex = 1;
            this.checkPrintResults.Text = "Print Transcription";
            this.checkPrintResults.UseVisualStyleBackColor = true;
            // 
            // UI
            // 
            this.AcceptButton = this.ActivateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 366);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "UI";
            this.ShowIcon = false;
            this.Text = "Voice Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainTabControl.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox TextOutput;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Button ActivateButton;
        private System.Windows.Forms.Button BedroomLightsOnButton;
        private System.Windows.Forms.Button BedroomLightsOffButton;
        private System.Windows.Forms.Button HeaterOnButton;
        private System.Windows.Forms.Button HeaterOffButton;
        private System.Windows.Forms.Button BathroomLightsOnButton;
        private System.Windows.Forms.Button BathroomLightsOffButton;
        private System.Windows.Forms.Button PlaybarVolumeUpButton;
        private System.Windows.Forms.Button PlaybarVolumeDownButton;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage MainTab;
        private System.Windows.Forms.TabPage BedroomTab;
        private System.Windows.Forms.TabPage WindowsTab;
        private System.Windows.Forms.TabPage HouseTab;
        private System.Windows.Forms.TabPage LivingRoomTab;
        private System.Windows.Forms.TabPage BathroomTab;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.CheckBox checkRunOnStart;
        private System.Windows.Forms.CheckBox checkPrintResults;
    }
}

