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
            this.SearchResultPanel = new System.Windows.Forms.Panel();
            this.SearchResultGrid = new System.Windows.Forms.DataGridView();
            this.SearchResultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchResultPanel
            // 
            this.SearchResultPanel.Controls.Add(this.SearchResultGrid);
            this.SearchResultPanel.Location = new System.Drawing.Point(39, 40);
            this.SearchResultPanel.Name = "SearchResultPanel";
            this.SearchResultPanel.Size = new System.Drawing.Size(988, 513);
            this.SearchResultPanel.TabIndex = 79;
            // 
            // SearchResultGrid
            // 
            this.SearchResultGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.SearchResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.SearchResultGrid.Location = new System.Drawing.Point(0, 0);
            this.SearchResultGrid.Name = "SearchResultGrid";
            this.SearchResultGrid.Size = new System.Drawing.Size(988, 513);
            this.SearchResultGrid.TabIndex = 0;
            // 
            // HeadacheB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchResultPanel);
            this.Name = "HeadacheB";
            this.Size = new System.Drawing.Size(1030, 542);
            this.SearchResultPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SearchResultPanel;
        private System.Windows.Forms.DataGridView SearchResultGrid;
    }
}
