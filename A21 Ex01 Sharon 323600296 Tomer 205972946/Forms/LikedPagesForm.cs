using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class LikedPagesForm : Form
    {
        private User m_LoggedInUser;

        public LikedPagesForm(User i_LoggedInUser)
        {
            InitializeComponent();
            this.m_LoggedInUser = i_LoggedInUser;
        }

        // PRIVATE METHODS
        private void fetchUserLikedPages()
        {
            foreach (Page fbPage in this.m_LoggedInUser.LikedPages)
            {
                this.listBoxUserLikedPages.Items.Add(string.Format("Name: {0} | Description: {1}", fbPage.Name, fbPage.Description));
            }

            if (this.m_LoggedInUser.LikedPages.Count == 0)
            {
                MessageBox.Show("The user has not liked any pages!");
            }
        }

        // EVENTS
        private void LikedPagesForm_Load(object sender, EventArgs e)
        {
            fetchUserLikedPages();
        }
    }
}
