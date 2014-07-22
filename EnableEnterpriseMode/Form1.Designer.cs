namespace EnableEnterpriseMode
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
            this.emBox = new System.Windows.Forms.CheckBox();
            this.inputLink = new System.Windows.Forms.TextBox();
            this.ieVerLabel = new System.Windows.Forms.Label();
            this.disableLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.siteLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emBox
            // 
            this.emBox.AutoSize = true;
            this.emBox.Location = new System.Drawing.Point(15, 109);
            this.emBox.Name = "emBox";
            this.emBox.Size = new System.Drawing.Size(306, 17);
            this.emBox.TabIndex = 0;
            this.emBox.Text = "Enable (Launch IE then navigate to site. Disable to Unlock)";
            this.emBox.UseVisualStyleBackColor = true;
            this.emBox.CheckedChanged += new System.EventHandler(this.emBox_CheckChanged);
            // 
            // inputLink
            // 
            this.inputLink.Location = new System.Drawing.Point(15, 83);
            this.inputLink.Name = "inputLink";
            this.inputLink.Size = new System.Drawing.Size(302, 20);
            this.inputLink.TabIndex = 1;
            this.inputLink.ReadOnlyChanged += new System.EventHandler(this.inputLink_ReadOnlyChanged);
            // 
            // ieVerLabel
            // 
            this.ieVerLabel.AutoSize = true;
            this.ieVerLabel.Location = new System.Drawing.Point(15, 31);
            this.ieVerLabel.Name = "ieVerLabel";
            this.ieVerLabel.Size = new System.Drawing.Size(0, 13);
            this.ieVerLabel.TabIndex = 2;
            // 
            // disableLabel
            // 
            this.disableLabel.AutoSize = true;
            this.disableLabel.Location = new System.Drawing.Point(323, 86);
            this.disableLabel.Name = "disableLabel";
            this.disableLabel.Size = new System.Drawing.Size(0, 13);
            this.disableLabel.TabIndex = 3;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(15, 9);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(365, 13);
            this.instructionsLabel.TabIndex = 4;
            this.instructionsLabel.Text = "You must verify IE Version is atleast 11. Click help button for program usage.";
            // 
            // siteLabel
            // 
            this.siteLabel.AutoSize = true;
            this.siteLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.siteLabel.Location = new System.Drawing.Point(15, 58);
            this.siteLabel.Name = "siteLabel";
            this.siteLabel.Size = new System.Drawing.Size(375, 13);
            this.siteLabel.TabIndex = 5;
            this.siteLabel.Text = "Site must be domain and subdomains only e.g. google.com or play.google.com";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(419, 3);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(27, 24);
            this.helpButton.TabIndex = 6;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 138);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.siteLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.disableLabel);
            this.Controls.Add(this.ieVerLabel);
            this.Controls.Add(this.inputLink);
            this.Controls.Add(this.emBox);
            this.Name = "Form1";
            this.Text = "Enable Enterprise Mode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox emBox;
        private System.Windows.Forms.TextBox inputLink;
        private System.Windows.Forms.Label ieVerLabel;
        private System.Windows.Forms.Label disableLabel;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label siteLabel;
        private System.Windows.Forms.Button helpButton;
    }
}

