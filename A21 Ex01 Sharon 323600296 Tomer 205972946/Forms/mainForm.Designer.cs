namespace A21_Ex01_Sharon_323600296_Tomer_205972946
{
    partial class mainForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.postStatusButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.functionsPanel = new System.Windows.Forms.Panel();
            this.postsBtn = new System.Windows.Forms.Button();
            this.activityPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.functionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.topPanel.Controls.Add(this.postStatusButton);
            this.topPanel.Controls.Add(this.statusLabel);
            this.topPanel.Controls.Add(this.statusTextBox);
            this.topPanel.Controls.Add(this.userNameLabel);
            this.topPanel.Controls.Add(this.loginBtn);
            this.topPanel.Controls.Add(this.profilePictureBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(689, 140);
            this.topPanel.TabIndex = 0;
            // 
            // postStatusButton
            // 
            this.postStatusButton.Location = new System.Drawing.Point(472, 73);
            this.postStatusButton.Margin = new System.Windows.Forms.Padding(4);
            this.postStatusButton.Name = "postStatusButton";
            this.postStatusButton.Size = new System.Drawing.Size(100, 23);
            this.postStatusButton.TabIndex = 8;
            this.postStatusButton.Text = "Post";
            this.postStatusButton.UseVisualStyleBackColor = true;
            this.postStatusButton.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(150, 42);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusLabel.Size = new System.Drawing.Size(81, 17);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "statusLabel";
            this.statusLabel.Visible = false;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(153, 73);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.statusTextBox.Size = new System.Drawing.Size(301, 60);
            this.statusTextBox.TabIndex = 6;
            this.statusTextBox.Text = " ";
            this.statusTextBox.Visible = false;
            this.statusTextBox.Enter += new System.EventHandler(this.statusTextBox_Enter);
            this.statusTextBox.Leave += new System.EventHandler(this.statusTextBox_Leave);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userNameLabel.Location = new System.Drawing.Point(150, 9);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(121, 20);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "userNameLabel";
            this.userNameLabel.Visible = false;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.loginBtn.Location = new System.Drawing.Point(304, 40);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(169, 56);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Image = global::A21_Ex01_Sharon_323600296_Tomer_205972946.Properties.Resources.facebookIcon;
            this.profilePictureBox.InitialImage = null;
            this.profilePictureBox.Location = new System.Drawing.Point(0, 0);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(145, 140);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            // 
            // functionsPanel
            // 
            this.functionsPanel.AutoScroll = true;
            this.functionsPanel.Controls.Add(this.postsBtn);
            this.functionsPanel.Location = new System.Drawing.Point(0, 140);
            this.functionsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.functionsPanel.Name = "functionsPanel";
            this.functionsPanel.Size = new System.Drawing.Size(145, 511);
            this.functionsPanel.TabIndex = 1;
            this.functionsPanel.Visible = false;
            // 
            // postsBtn
            // 
            this.postsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.postsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.postsBtn.Location = new System.Drawing.Point(0, 0);
            this.postsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.postsBtn.Name = "postsBtn";
            this.postsBtn.Size = new System.Drawing.Size(145, 37);
            this.postsBtn.TabIndex = 0;
            this.postsBtn.Text = "Posts";
            this.postsBtn.UseVisualStyleBackColor = true;
            this.postsBtn.Click += new System.EventHandler(this.postsBtn_Click);
            // 
            // activityPanel
            // 
            this.activityPanel.Location = new System.Drawing.Point(144, 140);
            this.activityPanel.Name = "activityPanel";
            this.activityPanel.Size = new System.Drawing.Size(545, 511);
            this.activityPanel.TabIndex = 2;
            this.activityPanel.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 651);
            this.Controls.Add(this.activityPanel);
            this.Controls.Add(this.functionsPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.functionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Panel functionsPanel;
        private System.Windows.Forms.Button postsBtn;
        private System.Windows.Forms.Panel activityPanel;
        private System.Windows.Forms.Button postStatusButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox statusTextBox;
    }
}