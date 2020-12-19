using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using Ex02.FacebookAppLogic.Classes;
using Ex02.FacebookAppUI.Loaders;
using System.Collections.Generic;
using Ex02.FacebookAppUI.Enums;

namespace Ex02.FacebookAppUI.Forms
{
    public partial class FriendsForm : Form
    {
        // ATTRIBUTES
        private readonly List<object> r_ParamsList;
        private User m_LoggedInUser;
        private Loader<User> m_ImageLoader;

        // CTOR
        public FriendsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.r_ParamsList = new List<object>() { this.m_LoggedInUser.Friends, this.friendsListView };
            this.m_ImageLoader = LoaderFactory<User>.CreateLoader(eLoaderFactoryContext.CreateImageLoader, this.r_ParamsList);
        }

        // PRIVATE METHODS
        private void FriendsForm_Load(object sender, System.EventArgs e)
        {
            new Thread(() => this.m_ImageLoader.LoadProperties("ImageLarge", "Name")).Start();
        }
    }
}