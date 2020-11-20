namespace Ex01.FacebookAppUI.Forms
{
    partial class FrienDiscoverForm
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
            this.reDiscoverBtn = new System.Windows.Forms.Button();
            this.profilePageBtn = new System.Windows.Forms.Button();
            this.FirstDegreePictureBox = new System.Windows.Forms.PictureBox();
            this.SecondDegreePictureBox = new System.Windows.Forms.PictureBox();
            this.firstChosenFriendLabel = new System.Windows.Forms.Label();
            this.secondChosenFriendLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FirstDegreePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondDegreePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // reDiscoverBtn
            // 
            this.reDiscoverBtn.Location = new System.Drawing.Point(61, 332);
            this.reDiscoverBtn.Name = "reDiscoverBtn";
            this.reDiscoverBtn.Size = new System.Drawing.Size(136, 62);
            this.reDiscoverBtn.TabIndex = 0;
            this.reDiscoverBtn.Text = "Discover Again";
            this.reDiscoverBtn.UseVisualStyleBackColor = false;
            this.reDiscoverBtn.Click += new System.EventHandler(this.reDiscoverBtn_Click);
            // 
            // profilePageBtn
            // 
            this.profilePageBtn.Location = new System.Drawing.Point(203, 332);
            this.profilePageBtn.Name = "profilePageBtn";
            this.profilePageBtn.Size = new System.Drawing.Size(135, 62);
            this.profilePageBtn.TabIndex = 1;
            this.profilePageBtn.Text = "Go to friend\'s page";
            this.profilePageBtn.UseVisualStyleBackColor = true;
            this.profilePageBtn.Click += new System.EventHandler(this.profilePageBtn_Click);
            // 
            // FirstDegreePictureBox
            // 
            this.FirstDegreePictureBox.Location = new System.Drawing.Point(122, 25);
            this.FirstDegreePictureBox.Name = "FirstDegreePictureBox";
            this.FirstDegreePictureBox.Size = new System.Drawing.Size(139, 129);
            this.FirstDegreePictureBox.TabIndex = 2;
            this.FirstDegreePictureBox.TabStop = false;
            // 
            // SecondDegreePictureBox
            // 
            this.SecondDegreePictureBox.Location = new System.Drawing.Point(113, 180);
            this.SecondDegreePictureBox.Name = "SecondDegreePictureBox";
            this.SecondDegreePictureBox.Size = new System.Drawing.Size(162, 146);
            this.SecondDegreePictureBox.TabIndex = 3;
            this.SecondDegreePictureBox.TabStop = false;
            // 
            // firstChosenFriendLabel
            // 
            this.firstChosenFriendLabel.AutoSize = true;
            this.firstChosenFriendLabel.Location = new System.Drawing.Point(133, 9);
            this.firstChosenFriendLabel.Name = "firstChosenFriendLabel";
            this.firstChosenFriendLabel.Size = new System.Drawing.Size(114, 13);
            this.firstChosenFriendLabel.TabIndex = 4;
            this.firstChosenFriendLabel.Text = "firstChosenFriendLabel";
            // 
            // secondChosenFriendLabel
            // 
            this.secondChosenFriendLabel.AutoSize = true;
            this.secondChosenFriendLabel.Location = new System.Drawing.Point(133, 164);
            this.secondChosenFriendLabel.Name = "secondChosenFriendLabel";
            this.secondChosenFriendLabel.Size = new System.Drawing.Size(133, 13);
            this.secondChosenFriendLabel.TabIndex = 5;
            this.secondChosenFriendLabel.Text = "secondChosenFriendLabel";
            // 
            // FrienDiscoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 406);
            this.Controls.Add(this.secondChosenFriendLabel);
            this.Controls.Add(this.firstChosenFriendLabel);
            this.Controls.Add(this.SecondDegreePictureBox);
            this.Controls.Add(this.FirstDegreePictureBox);
            this.Controls.Add(this.profilePageBtn);
            this.Controls.Add(this.reDiscoverBtn);
            this.Name = "FrienDiscoverForm";
            this.Text = "FrienDiscoverForm";
            ((System.ComponentModel.ISupportInitialize)(this.FirstDegreePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondDegreePictureBox)).EndInit();
            this.Load += new System.EventHandler(this.frienDiscoverForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button reDiscoverBtn;
        private System.Windows.Forms.Button profilePageBtn;
        private System.Windows.Forms.PictureBox FirstDegreePictureBox;
        private System.Windows.Forms.PictureBox SecondDegreePictureBox;
        private System.Windows.Forms.Label firstChosenFriendLabel;
        private System.Windows.Forms.Label secondChosenFriendLabel;
    }
}