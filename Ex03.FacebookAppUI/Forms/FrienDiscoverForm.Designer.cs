namespace Ex03.FacebookAppUI.Forms
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
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.goToRandomPersonProfileBtn = new System.Windows.Forms.Button();
            this.getRandomPersonBtn = new System.Windows.Forms.Button();
            this.newPersonInfoPanel = new System.Windows.Forms.Panel();
            this.newFriendAgeLbl = new System.Windows.Forms.Label();
            this.newFriendNameLbl = new System.Windows.Forms.Label();
            this.newFriendAboutLbl = new System.Windows.Forms.Label();
            this.firstDegreeFriendNameLbl = new System.Windows.Forms.Label();
            this.newFriendPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonsPanel.SuspendLayout();
            this.newPersonInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newFriendPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.goToRandomPersonProfileBtn);
            this.buttonsPanel.Controls.Add(this.getRandomPersonBtn);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 452);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(558, 45);
            this.buttonsPanel.TabIndex = 0;
            // 
            // goToRandomPersonProfileBtn
            // 
            this.goToRandomPersonProfileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(87)))));
            this.goToRandomPersonProfileBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.goToRandomPersonProfileBtn.FlatAppearance.BorderSize = 0;
            this.goToRandomPersonProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToRandomPersonProfileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.goToRandomPersonProfileBtn.Image = global::Ex03.FacebookAppUI.Properties.Resources.loveIcon;
            this.goToRandomPersonProfileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.goToRandomPersonProfileBtn.Location = new System.Drawing.Point(202, 0);
            this.goToRandomPersonProfileBtn.Name = "goToRandomPersonProfileBtn";
            this.goToRandomPersonProfileBtn.Size = new System.Drawing.Size(356, 45);
            this.goToRandomPersonProfileBtn.TabIndex = 3;
            this.goToRandomPersonProfileBtn.Text = "Go to profile";
            this.goToRandomPersonProfileBtn.UseVisualStyleBackColor = false;
            this.goToRandomPersonProfileBtn.Click += new System.EventHandler(this.goToRandomPersonProfileBtn_Click);
            // 
            // getRandomPersonBtn
            // 
            this.getRandomPersonBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.getRandomPersonBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.getRandomPersonBtn.FlatAppearance.BorderSize = 0;
            this.getRandomPersonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getRandomPersonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.getRandomPersonBtn.Image = global::Ex03.FacebookAppUI.Properties.Resources.randomIcon;
            this.getRandomPersonBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getRandomPersonBtn.Location = new System.Drawing.Point(0, 0);
            this.getRandomPersonBtn.Name = "getRandomPersonBtn";
            this.getRandomPersonBtn.Size = new System.Drawing.Size(202, 45);
            this.getRandomPersonBtn.TabIndex = 2;
            this.getRandomPersonBtn.Text = "Meet another person";
            this.getRandomPersonBtn.UseVisualStyleBackColor = false;
            this.getRandomPersonBtn.Click += new System.EventHandler(this.getRandomPersonBtn_Click);
            // 
            // newPersonInfoPanel
            // 
            this.newPersonInfoPanel.Controls.Add(this.newFriendAgeLbl);
            this.newPersonInfoPanel.Controls.Add(this.newFriendNameLbl);
            this.newPersonInfoPanel.Controls.Add(this.newFriendAboutLbl);
            this.newPersonInfoPanel.Controls.Add(this.firstDegreeFriendNameLbl);
            this.newPersonInfoPanel.Controls.Add(this.newFriendPictureBox);
            this.newPersonInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newPersonInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.newPersonInfoPanel.Name = "newPersonInfoPanel";
            this.newPersonInfoPanel.Size = new System.Drawing.Size(558, 452);
            this.newPersonInfoPanel.TabIndex = 1;
            // 
            // newFriendAgeLbl
            // 
            this.newFriendAgeLbl.AutoSize = true;
            this.newFriendAgeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.newFriendAgeLbl.Location = new System.Drawing.Point(16, 223);
            this.newFriendAgeLbl.Name = "newFriendAgeLbl";
            this.newFriendAgeLbl.Size = new System.Drawing.Size(32, 16);
            this.newFriendAgeLbl.TabIndex = 3;
            this.newFriendAgeLbl.Text = "age";
            this.newFriendAgeLbl.Visible = false;
            // 
            // newFriendNameLbl
            // 
            this.newFriendNameLbl.AutoSize = true;
            this.newFriendNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.newFriendNameLbl.Location = new System.Drawing.Point(16, 172);
            this.newFriendNameLbl.Name = "newFriendNameLbl";
            this.newFriendNameLbl.Size = new System.Drawing.Size(42, 16);
            this.newFriendNameLbl.TabIndex = 2;
            this.newFriendNameLbl.Text = "name";
            this.newFriendNameLbl.Visible = false;
            // 
            // newFriendAboutLbl
            // 
            this.newFriendAboutLbl.AutoSize = true;
            this.newFriendAboutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.newFriendAboutLbl.Location = new System.Drawing.Point(16, 277);
            this.newFriendAboutLbl.Name = "newFriendAboutLbl";
            this.newFriendAboutLbl.Size = new System.Drawing.Size(42, 16);
            this.newFriendAboutLbl.TabIndex = 1;
            this.newFriendAboutLbl.Text = "about";
            this.newFriendAboutLbl.Visible = false;
            // 
            // firstDegreeFriendNameLbl
            // 
            this.firstDegreeFriendNameLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.firstDegreeFriendNameLbl.AutoSize = true;
            this.firstDegreeFriendNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.firstDegreeFriendNameLbl.Location = new System.Drawing.Point(87, 9);
            this.firstDegreeFriendNameLbl.Name = "firstDegreeFriendNameLbl";
            this.firstDegreeFriendNameLbl.Size = new System.Drawing.Size(28, 16);
            this.firstDegreeFriendNameLbl.TabIndex = 0;
            this.firstDegreeFriendNameLbl.Text = "text";
            this.firstDegreeFriendNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.firstDegreeFriendNameLbl.Visible = false;
            // 
            // newFriendPictureBox
            // 
            this.newFriendPictureBox.Location = new System.Drawing.Point(19, 37);
            this.newFriendPictureBox.Name = "newFriendPictureBox";
            this.newFriendPictureBox.Size = new System.Drawing.Size(100, 100);
            this.newFriendPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newFriendPictureBox.TabIndex = 0;
            this.newFriendPictureBox.TabStop = false;
            this.newFriendPictureBox.Visible = false;
            // 
            // FrienDiscoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 497);
            this.Controls.Add(this.newPersonInfoPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Name = "FrienDiscoverForm";
            this.Load += new System.EventHandler(this.FrienDiscoverForm_Load);
            this.buttonsPanel.ResumeLayout(false);
            this.newPersonInfoPanel.ResumeLayout(false);
            this.newPersonInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newFriendPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button getRandomPersonBtn;
        private System.Windows.Forms.Button goToRandomPersonProfileBtn;
        private System.Windows.Forms.Panel newPersonInfoPanel;
        private System.Windows.Forms.PictureBox newFriendPictureBox;
        private System.Windows.Forms.Label firstDegreeFriendNameLbl;
        private System.Windows.Forms.Label newFriendAboutLbl;
        private System.Windows.Forms.Label newFriendAgeLbl;
        private System.Windows.Forms.Label newFriendNameLbl;
    }
}