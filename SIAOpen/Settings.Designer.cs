namespace SIAOpen
{
    partial class Settings
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
            this.saveButton = new System.Windows.Forms.Button();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.localPathLabel = new System.Windows.Forms.Label();
            this.serverLocationTextArea = new System.Windows.Forms.TextBox();
            this.localPathTextArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(185, 136);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 33);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(31, 81);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(85, 13);
            this.serverNameLabel.TabIndex = 2;
            this.serverNameLabel.Text = "Server Location:";
            // 
            // localPathLabel
            // 
            this.localPathLabel.AutoSize = true;
            this.localPathLabel.Location = new System.Drawing.Point(31, 113);
            this.localPathLabel.Name = "localPathLabel";
            this.localPathLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.localPathLabel.Size = new System.Drawing.Size(61, 13);
            this.localPathLabel.TabIndex = 3;
            this.localPathLabel.Text = "Local Path:";
            // 
            // serverLocationTextArea
            // 
            this.serverLocationTextArea.Location = new System.Drawing.Point(122, 78);
            this.serverLocationTextArea.Name = "serverLocationTextArea";
            this.serverLocationTextArea.Size = new System.Drawing.Size(295, 20);
            this.serverLocationTextArea.TabIndex = 4;
            // 
            // localPathTextArea
            // 
            this.localPathTextArea.Location = new System.Drawing.Point(94, 110);
            this.localPathTextArea.Name = "localPathTextArea";
            this.localPathTextArea.Size = new System.Drawing.Size(323, 20);
            this.localPathTextArea.TabIndex = 5;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 197);
            this.Controls.Add(this.localPathTextArea);
            this.Controls.Add(this.serverLocationTextArea);
            this.Controls.Add(this.localPathLabel);
            this.Controls.Add(this.serverNameLabel);
            this.Controls.Add(this.saveButton);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.Label localPathLabel;
        private System.Windows.Forms.TextBox serverLocationTextArea;
        private System.Windows.Forms.TextBox localPathTextArea;
    }
}