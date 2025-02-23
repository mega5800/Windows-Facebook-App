﻿namespace Ex03.FacebookAppUI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.postStatusButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.functionsPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.statisticsBtn = new System.Windows.Forms.Button();
            this.frienDiscoverBtn = new System.Windows.Forms.Button();
            this.eventsBtn = new System.Windows.Forms.Button();
            this.albumsBtn = new System.Windows.Forms.Button();
            this.groupsBtn = new System.Windows.Forms.Button();
            this.friendsBtn = new System.Windows.Forms.Button();
            this.likedPagesBtn = new System.Windows.Forms.Button();
            this.postsBtn = new System.Windows.Forms.Button();
            this.activityPanel = new System.Windows.Forms.Panel();
            this.refreshPictureBox = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.functionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.topPanel.Controls.Add(this.refreshPictureBox);
            this.topPanel.Controls.Add(this.checkBoxRememberUser);
            this.topPanel.Controls.Add(this.postStatusButton);
            this.topPanel.Controls.Add(this.statusLabel);
            this.topPanel.Controls.Add(this.statusTextBox);
            this.topPanel.Controls.Add(this.userNameLabel);
            this.topPanel.Controls.Add(this.profilePictureBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(684, 140);
            this.topPanel.TabIndex = 0;
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxRememberUser.Location = new System.Drawing.Point(446, 18);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(117, 20);
            this.checkBoxRememberUser.TabIndex = 10;
            this.checkBoxRememberUser.Text = "Remember me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            // 
            // postStatusButton
            // 
            this.postStatusButton.Location = new System.Drawing.Point(571, 90);
            this.postStatusButton.Margin = new System.Windows.Forms.Padding(4);
            this.postStatusButton.Name = "postStatusButton";
            this.postStatusButton.Size = new System.Drawing.Size(100, 23);
            this.postStatusButton.TabIndex = 8;
            this.postStatusButton.Text = "Post";
            this.postStatusButton.UseVisualStyleBackColor = true;
            this.postStatusButton.Click += new System.EventHandler(this.postStatusButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(150, 52);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLabel.Size = new System.Drawing.Size(81, 17);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "statusLabel";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(153, 73);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.statusTextBox.Size = new System.Drawing.Size(410, 60);
            this.statusTextBox.TabIndex = 9;
            this.statusTextBox.Enter += new System.EventHandler(this.statusTextBox_Enter);
            this.statusTextBox.Leave += new System.EventHandler(this.statusTextBox_Leave);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userNameLabel.Location = new System.Drawing.Point(149, 18);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(121, 20);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "userNameLabel";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.ErrorImage = global::Ex03.FacebookAppUI.Properties.Resources.facebookIcon;
            this.profilePictureBox.Image = global::Ex03.FacebookAppUI.Properties.Resources.facebookIcon;
            this.profilePictureBox.InitialImage = null;
            this.profilePictureBox.Location = new System.Drawing.Point(0, 0);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(140, 140);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            // 
            // functionsPanel
            // 
            this.functionsPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.functionsPanel.Controls.Add(this.logoutBtn);
            this.functionsPanel.Controls.Add(this.statisticsBtn);
            this.functionsPanel.Controls.Add(this.frienDiscoverBtn);
            this.functionsPanel.Controls.Add(this.eventsBtn);
            this.functionsPanel.Controls.Add(this.albumsBtn);
            this.functionsPanel.Controls.Add(this.groupsBtn);
            this.functionsPanel.Controls.Add(this.friendsBtn);
            this.functionsPanel.Controls.Add(this.likedPagesBtn);
            this.functionsPanel.Controls.Add(this.postsBtn);
            this.functionsPanel.Location = new System.Drawing.Point(0, 140);
            this.functionsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.functionsPanel.Name = "functionsPanel";
            this.functionsPanel.Size = new System.Drawing.Size(140, 537);
            this.functionsPanel.TabIndex = 1;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.logoutBtn.Image = global::Ex03.FacebookAppUI.Properties.Resources.logoutIcon;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 480);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.logoutBtn.Size = new System.Drawing.Size(140, 60);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // statisticsBtn
            // 
            this.statisticsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.statisticsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.statisticsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.statisticsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statisticsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.statisticsBtn.Image = global::Ex03.FacebookAppUI.Properties.Resources.pieChartIcon;
            this.statisticsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticsBtn.Location = new System.Drawing.Point(0, 420);
            this.statisticsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.statisticsBtn.Name = "statisticsBtn";
            this.statisticsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.statisticsBtn.Size = new System.Drawing.Size(140, 60);
            this.statisticsBtn.TabIndex = 7;
            this.statisticsBtn.Text = "Statistics";
            this.statisticsBtn.UseVisualStyleBackColor = false;
            this.statisticsBtn.Click += new System.EventHandler(this.statisticsBtn_Click);
            // 
            // frienDiscoverBtn
            // 
            this.frienDiscoverBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.frienDiscoverBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.frienDiscoverBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.frienDiscoverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frienDiscoverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.frienDiscoverBtn.Image = global::Ex03.FacebookAppUI.Properties.Resources.newFriendIcon;
            this.frienDiscoverBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.frienDiscoverBtn.Location = new System.Drawing.Point(0, 360);
            this.frienDiscoverBtn.Margin = new System.Windows.Forms.Padding(4);
            this.frienDiscoverBtn.Name = "frienDiscoverBtn";
            this.frienDiscoverBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.frienDiscoverBtn.Size = new System.Drawing.Size(140, 60);
            this.frienDiscoverBtn.TabIndex = 6;
            this.frienDiscoverBtn.Text = "FrienDiscover";
            this.frienDiscoverBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.frienDiscoverBtn.UseVisualStyleBackColor = false;
            this.frienDiscoverBtn.Click += new System.EventHandler(this.frienDiscoverBtn_Click);
            // 
            // eventsBtn
            // 
            this.eventsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.eventsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.eventsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.eventsBtn.Image = global::Ex03.FacebookAppUI.Properties.Resources.eventIcon;
            this.eventsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eventsBtn.Location = new System.Drawing.Point(0, 300);
            this.eventsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.eventsBtn.Name = "eventsBtn";
            this.eventsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.eventsBtn.Size = new System.Drawing.Size(140, 60);
            this.eventsBtn.TabIndex = 5;
            this.eventsBtn.Text = "Events";
            this.eventsBtn.UseVisualStyleBackColor = false;
            this.eventsBtn.Click += new System.EventHandler(this.eventsBtn_Click);
            // 
            // albumsBtn
            // 
            this.albumsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.albumsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.albumsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.albumsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.albumsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.albumsBtn.Image = global::Ex03.FacebookAppUI.Properties.Resources.albumIcon;
            this.albumsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.albumsBtn.Location = new System.Drawing.Point(0, 240);
            this.albumsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.albumsBtn.Name = "albumsBtn";
            this.albumsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.albumsBtn.Size = new System.Drawing.Size(140, 60);
            this.albumsBtn.TabIndex = 4;
            this.albumsBtn.Text = "Albums";
            this.albumsBtn.UseVisualStyleBackColor = false;
            this.albumsBtn.Click += new System.EventHandler(this.albumsBtn_Click);
            // 
            // groupsBtn
            // 
            this.groupsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.groupsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.groupsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupsBtn.Image = global::Ex03.FacebookAppUI.Properties.Resources.group1Icon;
            this.groupsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.groupsBtn.Location = new System.Drawing.Point(0, 180);
            this.groupsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.groupsBtn.Name = "groupsBtn";
            this.groupsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.groupsBtn.Size = new System.Drawing.Size(140, 60);
            this.groupsBtn.TabIndex = 3;
            this.groupsBtn.Text = " Groups";
            this.groupsBtn.UseVisualStyleBackColor = false;
            this.groupsBtn.Click += new System.EventHandler(this.groupsBtn_Click);
            // 
            // friendsBtn
            // 
            this.friendsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.friendsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.friendsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.friendsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friendsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.friendsBtn.Image = global::Ex03.FacebookAppUI.Properties.Resources.friendIcon1;
            this.friendsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.friendsBtn.Location = new System.Drawing.Point(0, 120);
            this.friendsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.friendsBtn.Name = "friendsBtn";
            this.friendsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.friendsBtn.Size = new System.Drawing.Size(140, 60);
            this.friendsBtn.TabIndex = 2;
            this.friendsBtn.Text = " Friends";
            this.friendsBtn.UseVisualStyleBackColor = false;
            this.friendsBtn.Click += new System.EventHandler(this.friendsBtn_Click);
            // 
            // likedPagesBtn
            // 
            this.likedPagesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.likedPagesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.likedPagesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.likedPagesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likedPagesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.likedPagesBtn.Image = ((System.Drawing.Image)(resources.GetObject("likedPagesBtn.Image")));
            this.likedPagesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.likedPagesBtn.Location = new System.Drawing.Point(0, 60);
            this.likedPagesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.likedPagesBtn.Name = "likedPagesBtn";
            this.likedPagesBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.likedPagesBtn.Size = new System.Drawing.Size(140, 60);
            this.likedPagesBtn.TabIndex = 1;
            this.likedPagesBtn.Text = "Pages";
            this.likedPagesBtn.UseVisualStyleBackColor = false;
            this.likedPagesBtn.Click += new System.EventHandler(this.likedPagesBtn_Click);
            // 
            // postsBtn
            // 
            this.postsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.postsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.postsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.postsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.postsBtn.Image = global::Ex03.FacebookAppUI.Properties.Resources.postIcon;
            this.postsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.postsBtn.Location = new System.Drawing.Point(0, 0);
            this.postsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.postsBtn.Name = "postsBtn";
            this.postsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.postsBtn.Size = new System.Drawing.Size(140, 60);
            this.postsBtn.TabIndex = 0;
            this.postsBtn.Text = "Posts";
            this.postsBtn.UseVisualStyleBackColor = false;
            this.postsBtn.Click += new System.EventHandler(this.postsBtn_Click);
            // 
            // activityPanel
            // 
            this.activityPanel.AutoScroll = true;
            this.activityPanel.BackColor = System.Drawing.Color.White;
            this.activityPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.activityPanel.Location = new System.Drawing.Point(140, 140);
            this.activityPanel.Name = "activityPanel";
            this.activityPanel.Size = new System.Drawing.Size(544, 536);
            this.activityPanel.TabIndex = 2;
            // 
            // refreshPictureBox
            // 
            this.refreshPictureBox.Image = global::Ex03.FacebookAppUI.Properties.Resources.refreshIcon;
            this.refreshPictureBox.Location = new System.Drawing.Point(571, 18);
            this.refreshPictureBox.Name = "refreshPictureBox";
            this.refreshPictureBox.Size = new System.Drawing.Size(24, 24);
            this.refreshPictureBox.TabIndex = 11;
            this.refreshPictureBox.TabStop = false;
            this.refreshPictureBox.Click += new System.EventHandler(this.refreshPictureBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 676);
            this.Controls.Add(this.activityPanel);
            this.Controls.Add(this.functionsPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main Page";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.functionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refreshPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Panel functionsPanel;
        private System.Windows.Forms.Button postsBtn;
        private System.Windows.Forms.Panel activityPanel;
        private System.Windows.Forms.Button postStatusButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Button statisticsBtn;
        private System.Windows.Forms.Button eventsBtn;
        private System.Windows.Forms.Button albumsBtn;
        private System.Windows.Forms.Button groupsBtn;
        private System.Windows.Forms.Button friendsBtn;
        private System.Windows.Forms.Button likedPagesBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button frienDiscoverBtn;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private System.Windows.Forms.PictureBox refreshPictureBox;
    }
}