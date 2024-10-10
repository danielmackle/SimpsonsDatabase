namespace SimpsonsSystem.Frontend.Forms
{
    partial class FrmReport
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
            this.lbxWeddingList = new System.Windows.Forms.ListBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblWeddingList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxWeddingList
            // 
            this.lbxWeddingList.FormattingEnabled = true;
            this.lbxWeddingList.ItemHeight = 27;
            this.lbxWeddingList.Location = new System.Drawing.Point(26, 40);
            this.lbxWeddingList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbxWeddingList.Name = "lbxWeddingList";
            this.lbxWeddingList.Size = new System.Drawing.Size(746, 571);
            this.lbxWeddingList.TabIndex = 0;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(283, 640);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(489, 34);
            this.tbxSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(32, 640);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(241, 27);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search Wedding Lists:";
            // 
            // lblWeddingList
            // 
            this.lblWeddingList.AutoSize = true;
            this.lblWeddingList.Location = new System.Drawing.Point(26, 9);
            this.lblWeddingList.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWeddingList.Name = "lblWeddingList";
            this.lblWeddingList.Size = new System.Drawing.Size(267, 27);
            this.lblWeddingList.TabIndex = 3;
            this.lblWeddingList.Text = "Available Wedding Lists:";
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 709);
            this.Controls.Add(this.lblWeddingList);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lbxWeddingList);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmReport";
            this.Text = "FrmReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxWeddingList;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblWeddingList;
    }
}