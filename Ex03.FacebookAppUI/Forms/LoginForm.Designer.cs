namespace Ex03.FacebookAppUI.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginFormPanel = new System.Windows.Forms.Panel();
            this.facebookLogoPicture = new System.Windows.Forms.PictureBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // loginFormPanel
            // 
            this.loginFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(156)))));
            this.loginFormPanel.Controls.Add(this.facebookLogoPicture);
            this.loginFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginFormPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.loginFormPanel.Location = new System.Drawing.Point(0, 0);
            this.loginFormPanel.Name = "loginFormPanel";
            this.loginFormPanel.Size = new System.Drawing.Size(668, 140);
            this.loginFormPanel.TabIndex = 0;
            // 
            // facebookLogoPicture
            // 
            this.facebookLogoPicture.ErrorImage = global::Ex02.FacebookAppUI.Properties.Resources.facebookIcon;
            this.facebookLogoPicture.Image = global::Ex02.FacebookAppUI.Properties.Resources.facebookIcon;
            this.facebookLogoPicture.InitialImage = null;
            this.facebookLogoPicture.Location = new System.Drawing.Point(0, 0);
            this.facebookLogoPicture.Margin = new System.Windows.Forms.Padding(4);
            this.facebookLogoPicture.Name = "facebookLogoPicture";
            this.facebookLogoPicture.Size = new System.Drawing.Size(140, 140);
            this.facebookLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebookLogoPicture.TabIndex = 2;
            this.facebookLogoPicture.TabStop = false;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.loginBtn.Location = new System.Drawing.Point(250, 42);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(169, 56);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 140);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginFormPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.loginFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facebookLogoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginFormPanel;
        private System.Windows.Forms.PictureBox facebookLogoPicture;
        private System.Windows.Forms.Button loginBtn;
    }
}