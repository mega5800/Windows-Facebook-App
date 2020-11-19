using Ex01.FacebookAppLogic.Classes;
using FacebookWrapper;
using System;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class LoginForm : Form
    {
        private LoginResult m_LoginResult;
        private MainForm m_MainFormToShow;
        private const string k_AppId = "359957661732863";
        private readonly string[] r_PermissionsArray = new string[]
        {
          "public_profile", "email", "user_birthday", "user_videos",
          "user_age_range", "user_gender", "user_link", "user_tagged_places",
          "user_friends", "user_events", "user_likes", "user_location",
          "user_photos", "user_posts", "user_hometown"/*, "user_groups"*/
        };

        public LoginForm()
        {
            InitializeComponent();
        }

        // PRIVATE METHODS
        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.m_LoginResult = FacebookService.Login(k_AppId, r_PermissionsArray);
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                LoggedInUser.ConvertToLoggedInUserObject(ref m_LoginResult);
                showMainForm();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage);
            }
        }

        private void showMainForm()
        {
            this.m_MainFormToShow = new MainForm();
            this.Hide();
            this.m_MainFormToShow.ShowDialog();
            this.Close();
        }

        // EVENTS
        private void LoginForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}