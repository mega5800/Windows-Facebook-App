namespace Ex02.FacebookAppUI.Forms
{
    partial class LikedPagesForm
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
        private void InitializeComponent()
        {
            this.listBoxUserLikedPages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxUserEvents
            // 
            this.listBoxUserLikedPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxUserLikedPages.FormattingEnabled = true;
            this.listBoxUserLikedPages.ItemHeight = 16;
            this.listBoxUserLikedPages.Location = new System.Drawing.Point(0, 0);
            this.listBoxUserLikedPages.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxUserLikedPages.Name = "listBoxUserLikedPages";
            this.listBoxUserLikedPages.Size = new System.Drawing.Size(435, 420);
            this.listBoxUserLikedPages.TabIndex = 3;
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 406);
            this.Controls.Add(this.listBoxUserLikedPages);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LikedPagesForm";
            this.Text = "likedPagesForm";
            this.Load += new System.EventHandler(this.LikedPagesForm_Load);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ListBox listBoxUserLikedPages;
    }
}