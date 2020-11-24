using System;
using System.Threading;
using System.Windows.Forms;
using Ex01.FacebookAppLogic.Classes;
using Ex01.FacebookAppUI.Classes;
using FacebookWrapper.ObjectModel;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class LikedPagesForm : Form
    {
        // ATTRIBUTES
        private readonly Thread r_StartThread;
        private User m_LoggedInUser;
        private TextLoader<Page> m_TextLoader;

        // CTOR
        public LikedPagesForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.r_StartThread = new Thread(new ThreadStart(loadForm));
            this.m_TextLoader = new TextLoader<Page>(this.m_LoggedInUser.LikedPages, this.listBoxUserLikedPages, "Name: {0} | Description: {1}");
        }

        // PRIVATE METHODS
        private void loadForm()
        {
            if (this.m_LoggedInUser.LikedPages.Count != 0)
            {
                this.m_TextLoader.LoadTextProperty("Name", "Description");
            }
            else
            {
                MessageBox.Show(string.Format("{0}, you do not have any liked pages!", this.m_LoggedInUser.FirstName));
            }
        }

        // EVENTS
        private void LikedPagesForm_Load(object sender, EventArgs e)
        {
            this.r_StartThread.Start();
        }
    }
}