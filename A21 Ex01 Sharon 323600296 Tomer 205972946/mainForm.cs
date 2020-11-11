using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A21_Ex01_Sharon_323600296_Tomer_205972946
{
    public partial class mainForm : Form
    {
        private readonly Size r_SmallSize = new Size(111,690);
        private readonly Size r_BigSize = new Size(705, 690);
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;
        private const string k_AppId = "359957661732863";
        private readonly string[] r_PermissionsArray = new string[]
        {
          "public_profile", "email", "user_birthday", "user_videos",
          "user_age_range", "user_gender", "user_link", "user_tagged_places",
          "user_friends", "user_events", "user_likes", "user_location",
          "user_photos", "user_posts", "user_hometown"
        };

        public mainForm()
        {
            this.Size = r_SmallSize;
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.m_LoginResult = FacebookService.Login(k_AppId, r_PermissionsArray);
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                prepareFromForUserInfoDisplay();
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage);
            }
        }

        private void prepareFromForUserInfoDisplay()
        {
            this.Size = r_BigSize;
            CenterToScreen();
            this.funcationsPanel.Visible = true;
            this.userNameLabel.Visible = true;
            this.loginBtn.Visible = false;
        }

        private void fetchUserInfo()
        {
            this.userNameLabel.Text = this.m_LoggedInUser.Name;
            this.profilePictureBox.LoadAsync(this.m_LoggedInUser.PictureNormalURL);
        }
    }
}
