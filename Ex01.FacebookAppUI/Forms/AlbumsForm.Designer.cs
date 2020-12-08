namespace Ex02.FacebookAppUI.Forms
{
    partial class AlbumsForm
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
            this.albumsListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // albumsListView
            // 
            this.albumsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albumsListView.HideSelection = false;
            this.albumsListView.Location = new System.Drawing.Point(0, 0);
            this.albumsListView.Name = "albumsListView";
            this.albumsListView.Size = new System.Drawing.Size(800, 450);
            this.albumsListView.TabIndex = 0;
            this.albumsListView.UseCompatibleStateImageBehavior = false;
            this.albumsListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.albumsListView_MouseDoubleClick);
            // 
            // AlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.albumsListView);
            this.Name = "AlbumsForm";
            this.Text = "AlbumsForm";
            this.Load += new System.EventHandler(this.AlbumsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView albumsListView;
    }
}