using Ex01.FacebookAppLogic.Classes;
using Ex01.FacebookAppUI.Classes;
using FacebookWrapper;
using System;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class LoginForm : Form
    {
        // ATTRIBUTES
        private LoginResult m_LoginResult;
        private AppSettings m_AppSettings;
        private MainForm m_MainFormToShow;
        private const string k_AppId = "359957661732863";
        private readonly string[] r_PermissionsArray = new string[]
        {
          "public_profile", "email", "user_birthday", "user_videos",
          "user_age_range", "user_gender", "user_link", "user_tagged_places",
          "user_friends", "user_events", "user_likes", "user_location",
          "user_photos", "user_posts", "user_hometown"/*, "user_groups"*/
        };

        // CTOR
        public LoginForm(AppSettings i_AppSettings)
        {
            InitializeComponent();
            this.m_AppSettings = i_AppSettings;
        }

        // PRIVATE METHODS
        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.m_LoginResult = FacebookService.Login(k_AppId, r_PermissionsArray);
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                this.m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
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
            this.m_MainFormToShow = new MainForm(this.m_AppSettings);
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