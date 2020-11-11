namespace A21_Ex01_Sharon_323600296_Tomer_205972946
{
    partial class postForm
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
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.listBoxUserPosts = new System.Windows.Forms.ListBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.postStatusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(12, 33);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(227, 20);
            this.statusTextBox.TabIndex = 2;
            this.statusTextBox.Text = " ";
            this.statusTextBox.Enter += new System.EventHandler(this.statusTextBox_Enter);
            this.statusTextBox.Leave += new System.EventHandler(this.statusTextBox_Leave);
            // 
            // listBoxUserPosts
            // 
            this.listBoxUserPosts.FormattingEnabled = true;
            this.listBoxUserPosts.Location = new System.Drawing.Point(12, 60);
            this.listBoxUserPosts.Name = "listBoxUserPosts";
            this.listBoxUserPosts.Size = new System.Drawing.Size(308, 264);
            this.listBoxUserPosts.TabIndex = 3;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 17);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLabel.Size = new System.Drawing.Size(61, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "statusLabel";
            // 
            // postStatusButton
            // 
            this.postStatusButton.Location = new System.Drawing.Point(245, 31);
            this.postStatusButton.Name = "postStatusButton";
            this.postStatusButton.Size = new System.Drawing.Size(75, 23);
            this.postStatusButton.TabIndex = 5;
            this.postStatusButton.Text = "Post";
            this.postStatusButton.UseVisualStyleBackColor = true;
            this.postStatusButton.Click += new System.EventHandler(this.postStatusButton_Click);
            // 
            // postForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 494);
            this.Controls.Add(this.postStatusButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.listBoxUserPosts);
            this.Controls.Add(this.statusTextBox);
            this.Name = "postForm";
            this.Text = "postForm";
            this.Load += new System.EventHandler(this.postForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.ListBox listBoxUserPosts;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button postStatusButton;
    }

}