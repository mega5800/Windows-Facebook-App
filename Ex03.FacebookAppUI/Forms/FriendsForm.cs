using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using Ex03.FacebookAppLogic.Classes;
using Ex03.FacebookAppUI.Loaders;
using Ex03.FacebookAppUI.Enums;
using Ex03.FacebookAppUI.Interfaces;
using Ex03.FacebookAppUI.Classes;

namespace Ex03.FacebookAppUI.Forms
{
    public partial class FriendsForm : Form, IRefreshable
    {
        // ATTRIBUTES
        private ILoaderAdapter<User> m_LoaderAdapter;
        private User m_LoggedInUser;
        private Loader<User> m_ImageLoader;

        // CTOR
        public FriendsForm()
        {
            InitializeComponent();
            this.m_LoaderAdapter = new LoaderAdapter<User>();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.m_ImageLoader = this.m_LoaderAdapter.FormToLoaderAdapt(eLoaderFactoryContext.CreateImageLoader, this.m_LoggedInUser.Friends, this.friendsListView);
        }

        // PRIVATE METHODS
        private void startLoadPropertiesThread()
        {
            new Thread(() => this.m_ImageLoader.LoadProperties("ImageLarge", "Name")).Start();
        }

        // IREFRESHABLE IMPLEMENTATION
        void IRefreshable.RefreshDataInForm()
        {
            this.friendsListView.Clear();
            this.m_LoggedInUser.ReFetch();

            // since we're refreshing the data in the form, we need also to refresh the friends in m_ImageLoader
            this.m_ImageLoader.LoaderFacebookObjectCollection = this.m_LoggedInUser.Friends;
            startLoadPropertiesThread();
        }

        // EVENTS
        private void FriendsForm_Load(object sender, System.EventArgs e)
        {
            startLoadPropertiesThread();
        }
    }
}