namespace Ex01.FacebookAppUI.Forms
{
    partial class FriendsForm
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
            this.friendsListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // friendsListView
            // 
            this.friendsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.friendsListView.HideSelection = false;
            this.friendsListView.Location = new System.Drawing.Point(0, 0);
            this.friendsListView.Name = "friendsListView";
            this.friendsListView.Size = new System.Drawing.Size(800, 450);
            this.friendsListView.TabIndex = 0;
            this.friendsListView.UseCompatibleStateImageBehavior = false;
            // 
            // FriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.friendsListView);
            this.Name = "FriendsForm";
            this.Text = "friendsForm";
            this.Load += new System.EventHandler(this.FriendsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView friendsListView;
    }
}