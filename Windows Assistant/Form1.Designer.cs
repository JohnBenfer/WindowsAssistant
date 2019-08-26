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
            this.SuspendLayout();
            // 
            // RecordButton
            // 
            this.RecordButton.Location = new System.Drawing.Point(12, 48);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(151, 67);
            this.RecordButton.TabIndex = 0;
            this.RecordButton.Text = "Record";
            this.RecordButton.UseVisualStyleBackColor = true;
            this.RecordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(805, 48);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(151, 67);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // TextOutput
            // 
            this.TextOutput.Location = new System.Drawing.Point(12, 130);
            this.TextOutput.Multiline = true;
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.ReadOnly = true;
            this.TextOutput.Size = new System.Drawing.Size(944, 670);
            this.TextOutput.TabIndex = 2;
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(189, 48);
            this.TextInput.Multiline = true;
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(588, 66);
            this.TextInput.TabIndex = 3;
            this.TextInput.TextChanged += new System.EventHandler(this.TextInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 812);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.TextOutput);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.RecordButton);
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
    }
}

