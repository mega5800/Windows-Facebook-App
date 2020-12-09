using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Ex02.FacebookAppLogic.Classes;
using Ex02.FacebookAppUI.Enums;
using Ex02.FacebookAppUI.Loaders;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Forms
{
    public partial class LikedPagesForm : Form
    {
        // ATTRIBUTES
        private readonly Thread r_StartThread;
        private readonly List<object> r_ParamsList;
        private User m_LoggedInUser;
        private Loader<Page> m_TextLoader;

        // CTOR
        public LikedPagesForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.r_ParamsList = new List<object>() { this.m_LoggedInUser.LikedPages, this.listBoxUserLikedPages, "Name: {0} | Description: {1}" };
            this.r_StartThread = new Thread(new ThreadStart(loadForm));
            this.m_TextLoader = LoaderFactory<Page>.CreateLoader(eLoaderFactoryContext.CreateTextLoader, this.r_ParamsList);
        }

        // PRIVATE METHODS
        private void loadForm()
        {
            if (this.m_LoggedInUser.LikedPages.Count != 0)
            {
                this.m_TextLoader.LoadProperties("Name", "Description");
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