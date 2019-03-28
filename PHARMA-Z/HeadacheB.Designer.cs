namespace PHARMA_Z
{
    partial class HeadacheB
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
            this.HeadachePanel = new System.Windows.Forms.Panel();
            this.HeadacheGrid = new System.Windows.Forms.DataGridView();
            this.HeadachePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeadacheGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadachePanel
            // 
            this.HeadachePanel.Controls.Add(this.HeadacheGrid);
            this.HeadachePanel.Location = new System.Drawing.Point(24, 26);
            this.HeadachePanel.Name = "HeadachePanel";
            this.HeadachePanel.Size = new System.Drawing.Size(988, 513);
            this.HeadachePanel.TabIndex = 77;
            // 
            // HeadacheGrid
            // 
            this.HeadacheGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.HeadacheGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HeadacheGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeadacheGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.HeadacheGrid.Location = new System.Drawing.Point(0, 0);
            this.HeadacheGrid.Name = "HeadacheGrid";
            this.HeadacheGrid.Size = new System.Drawing.Size(988, 513);
            this.HeadacheGrid.TabIndex = 0;
            // 
            // HeadacheB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HeadachePanel);
            this.Name = "HeadacheB";
            this.Size = new System.Drawing.Size(1030, 542);
            this.HeadachePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HeadacheGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeadachePanel;
        private System.Windows.Forms.DataGridView HeadacheGrid;
    }
}
