namespace Windows_Assistant
{
    partial class Form1
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
            this.RecordButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.TextOutput = new System.Windows.Forms.TextBox();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.google_button = new System.Windows.Forms.Button();
            this.apitest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RecordButton
            // 
            this.RecordButton.Location = new System.Drawing.Point(12, 48);
            this.RecordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(151, 68);
            this.RecordButton.TabIndex = 0;
            this.RecordButton.Text = "Record";
            this.RecordButton.UseVisualStyleBackColor = true;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(806, 48);
            this.StopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(151, 68);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // TextOutput
            // 
            this.TextOutput.Location = new System.Drawing.Point(12, 130);
            this.TextOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextOutput.Multiline = true;
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.ReadOnly = true;
            this.TextOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextOutput.Size = new System.Drawing.Size(944, 670);
            this.TextOutput.TabIndex = 2;
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(189, 48);
            this.TextInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextInput.Multiline = true;
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(588, 66);
            this.TextInput.TabIndex = 3;
            this.TextInput.TextChanged += new System.EventHandler(this.TextInput_TextChanged);
            // 
            // google_button
            // 
            this.google_button.Location = new System.Drawing.Point(627, 48);
            this.google_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.google_button.Name = "google_button";
            this.google_button.Size = new System.Drawing.Size(151, 68);
            this.google_button.TabIndex = 4;
            this.google_button.Text = "Google API";
            this.google_button.UseVisualStyleBackColor = true;
            this.google_button.Click += new System.EventHandler(this.google_button_Click);
            // 
            // apitest
            // 
            this.apitest.Location = new System.Drawing.Point(13, 13);
            this.apitest.Name = "apitest";
            this.apitest.Size = new System.Drawing.Size(150, 30);
            this.apitest.TabIndex = 5;
            this.apitest.Text = "api test";
            this.apitest.UseVisualStyleBackColor = true;
            this.apitest.Click += new System.EventHandler(this.apitest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 812);
            this.Controls.Add(this.apitest);
            this.Controls.Add(this.google_button);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.RecordButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RecordButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox TextOutput;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Button google_button;
        private System.Windows.Forms.Button apitest;
    }
}

