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
            this.loginBtn = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.funcationsPanel = new System.Windows.Forms.Panel();
            this.postBtn = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.funcationsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.topPanel.Controls.Add(this.userNameLabel);
            this.topPanel.Controls.Add(this.loginBtn);
            this.topPanel.Controls.Add(this.profilePictureBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(689, 111);
            this.topPanel.TabIndex = 0;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.loginBtn.Image = global::A21_Ex01_Sharon_323600296_Tomer_205972946.Properties.Resources.loginIcon;
            this.loginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginBtn.Location = new System.Drawing.Point(353, 15);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(151, 81);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Image = global::A21_Ex01_Sharon_323600296_Tomer_205972946.Properties.Resources.facebookIcon;
            this.profilePictureBox.InitialImage = null;
            this.profilePictureBox.Location = new System.Drawing.Point(0, 0);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(120, 111);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userNameLabel.Location = new System.Drawing.Point(128, 48);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(0, 17);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Visible = false;
            // 
            // funcationsPanel
            // 
            this.funcationsPanel.Controls.Add(this.postBtn);
            this.funcationsPanel.Location = new System.Drawing.Point(0, 118);
            this.funcationsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.funcationsPanel.Name = "funcationsPanel";
            this.funcationsPanel.Size = new System.Drawing.Size(120, 485);
            this.funcationsPanel.TabIndex = 1;
            this.funcationsPanel.Visible = false;
            // 
            // postBtn
            // 
            this.postBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.postBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.postBtn.Location = new System.Drawing.Point(0, 0);
            this.postBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postBtn.Name = "postBtn";
            this.postBtn.Size = new System.Drawing.Size(120, 37);
            this.postBtn.TabIndex = 0;
            this.postBtn.Text = "Posts";
            this.postBtn.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 651);
            this.Controls.Add(this.funcationsPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.funcationsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Panel funcationsPanel;
        private System.Windows.Forms.Button postBtn;
    }
}