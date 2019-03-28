namespace PHARMA_Z
{
    partial class DisclaimerAbout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisclaimerAbout));
            this.DisclaimerPanel = new System.Windows.Forms.Panel();
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.AboutPanelIcon = new System.Windows.Forms.Panel();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.DisclaimerPanelIcon = new System.Windows.Forms.Panel();
            this.DisclaimerLabel = new System.Windows.Forms.Label();
            this.DisclaimerPanel.SuspendLayout();
            this.AboutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisclaimerPanel
            // 
            this.DisclaimerPanel.Controls.Add(this.AboutPanel);
            this.DisclaimerPanel.Controls.Add(this.DisclaimerPanelIcon);
            this.DisclaimerPanel.Controls.Add(this.DisclaimerLabel);
            this.DisclaimerPanel.Location = new System.Drawing.Point(52, 42);
            this.DisclaimerPanel.Name = "DisclaimerPanel";
            this.DisclaimerPanel.Size = new System.Drawing.Size(988, 513);
            this.DisclaimerPanel.TabIndex = 82;
            // 
            // AboutPanel
            // 
            this.AboutPanel.Controls.Add(this.AboutPanelIcon);
            this.AboutPanel.Controls.Add(this.AboutLabel);
            this.AboutPanel.Location = new System.Drawing.Point(12, 24);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(988, 513);
            this.AboutPanel.TabIndex = 82;
            // 
            // AboutPanelIcon
            // 
            this.AboutPanelIcon.BackColor = System.Drawing.Color.Transparent;
            this.AboutPanelIcon.BackgroundImage = global::PHARMA_Z.Properties.Resources.logo_title_light;
            this.AboutPanelIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AboutPanelIcon.Location = new System.Drawing.Point(880, 380);
            this.AboutPanelIcon.Name = "AboutPanelIcon";
            this.AboutPanelIcon.Size = new System.Drawing.Size(96, 54);
            this.AboutPanelIcon.TabIndex = 75;
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutLabel.Location = new System.Drawing.Point(19, 48);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(884, 232);
            this.AboutLabel.TabIndex = 0;
            this.AboutLabel.Text = resources.GetString("AboutLabel.Text");
            // 
            // DisclaimerPanelIcon
            // 
            this.DisclaimerPanelIcon.BackColor = System.Drawing.Color.Transparent;
            this.DisclaimerPanelIcon.BackgroundImage = global::PHARMA_Z.Properties.Resources.logo_title_light;
            this.DisclaimerPanelIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DisclaimerPanelIcon.Location = new System.Drawing.Point(880, 380);
            this.DisclaimerPanelIcon.Name = "DisclaimerPanelIcon";
            this.DisclaimerPanelIcon.Size = new System.Drawing.Size(96, 54);
            this.DisclaimerPanelIcon.TabIndex = 75;
            // 
            // DisclaimerLabel
            // 
            this.DisclaimerLabel.AutoSize = true;
            this.DisclaimerLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisclaimerLabel.Location = new System.Drawing.Point(8, 49);
            this.DisclaimerLabel.Name = "DisclaimerLabel";
            this.DisclaimerLabel.Size = new System.Drawing.Size(977, 261);
            this.DisclaimerLabel.TabIndex = 0;
            this.DisclaimerLabel.Text = resources.GetString("DisclaimerLabel.Text");
            // 
            // DisclaimerAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DisclaimerPanel);
            this.Name = "DisclaimerAbout";
            this.Size = new System.Drawing.Size(1093, 596);
            this.DisclaimerPanel.ResumeLayout(false);
            this.DisclaimerPanel.PerformLayout();
            this.AboutPanel.ResumeLayout(false);
            this.AboutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DisclaimerPanel;
        private System.Windows.Forms.Panel AboutPanel;
        private System.Windows.Forms.Panel AboutPanelIcon;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.Panel DisclaimerPanelIcon;
        private System.Windows.Forms.Label DisclaimerLabel;
    }
}
