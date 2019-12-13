﻿namespace Windows_Assistant
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.WindowsTab = new System.Windows.Forms.TabPage();
            this.BedroomTab = new System.Windows.Forms.TabPage();
            this.LivingRoomTab = new System.Windows.Forms.TabPage();
            this.BathroomTab = new System.Windows.Forms.TabPage();
            this.HouseTab = new System.Windows.Forms.TabPage();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.checkRunOnStart = new System.Windows.Forms.CheckBox();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(405, 59);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Bedroom Lights On";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(525, 59);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 60);
            this.button2.TabIndex = 15;
            this.button2.Text = "Bedroom Lights Off";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(405, 124);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 60);
            this.button3.TabIndex = 16;
            this.button3.Text = "Heater On";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(525, 124);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 60);
            this.button4.TabIndex = 17;
            this.button4.Text = "Heater Off";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Location = new System.Drawing.Point(405, 189);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 60);
            this.button5.TabIndex = 18;
            this.button5.Text = "Bathroom Lamp On";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button6.Location = new System.Drawing.Point(525, 189);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 60);
            this.button6.TabIndex = 19;
            this.button6.Text = "Bathroom Lamp Off";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button7.Location = new System.Drawing.Point(405, 254);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 60);
            this.button7.TabIndex = 20;
            this.button7.Text = "Playbar Volume Up";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button8.Location = new System.Drawing.Point(525, 254);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 60);
            this.button8.TabIndex = 21;
            this.button8.Text = "Playbar Vol Down";
            this.button8.UseVisualStyleBackColor = true;
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
            this.MainTab.Controls.Add(this.button8);
            this.MainTab.Controls.Add(this.StopButton);
            this.MainTab.Controls.Add(this.button7);
            this.MainTab.Controls.Add(this.TextOutput);
            this.MainTab.Controls.Add(this.button6);
            this.MainTab.Controls.Add(this.ActivateButton);
            this.MainTab.Controls.Add(this.button5);
            this.MainTab.Controls.Add(this.button1);
            this.MainTab.Controls.Add(this.button4);
            this.MainTab.Controls.Add(this.button2);
            this.MainTab.Controls.Add(this.button3);
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
            this.SettingsTab.Controls.Add(this.checkRunOnStart);
            this.SettingsTab.Location = new System.Drawing.Point(4, 31);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(650, 327);
            this.SettingsTab.TabIndex = 6;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // checkRunOnStart
            // 
            this.checkRunOnStart.AutoSize = true;
            this.checkRunOnStart.Location = new System.Drawing.Point(8, 7);
            this.checkRunOnStart.Name = "checkRunOnStart";
            this.checkRunOnStart.Size = new System.Drawing.Size(141, 24);
            this.checkRunOnStart.TabIndex = 0;
            this.checkRunOnStart.Text = "Run on startup";
            this.checkRunOnStart.UseVisualStyleBackColor = true;
            this.checkRunOnStart.CheckedChanged += new System.EventHandler(this.checkRunOnStart_CheckedChanged);
            // 
            // UI
            // 
            this.AcceptButton = this.ActivateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 366);
            this.Controls.Add(this.MainTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage MainTab;
        private System.Windows.Forms.TabPage BedroomTab;
        private System.Windows.Forms.TabPage WindowsTab;
        private System.Windows.Forms.TabPage HouseTab;
        private System.Windows.Forms.TabPage LivingRoomTab;
        private System.Windows.Forms.TabPage BathroomTab;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.CheckBox checkRunOnStart;
    }
}

