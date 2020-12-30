namespace Ex03.FacebookAppUI.Forms
{
    partial class SelectedAlbumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectedAlbumForm));
            this.selectedAlbumlistView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // selectedAlbumlistView
            // 
            this.selectedAlbumlistView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedAlbumlistView.HideSelection = false;
            this.selectedAlbumlistView.Location = new System.Drawing.Point(0, 0);
            this.selectedAlbumlistView.Name = "selectedAlbumlistView";
            this.selectedAlbumlistView.Size = new System.Drawing.Size(437, 289);
            this.selectedAlbumlistView.TabIndex = 0;
            this.selectedAlbumlistView.UseCompatibleStateImageBehavior = false;
            // 
            // SelectedAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 289);
            this.Controls.Add(this.selectedAlbumlistView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectedAlbumForm";
            this.Text = "SelectedAlbumForm";
            this.Load += new System.EventHandler(this.SelectedAlbumForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView selectedAlbumlistView;
    }
}