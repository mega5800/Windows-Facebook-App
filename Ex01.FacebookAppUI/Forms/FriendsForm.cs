using FacebookWrapper.ObjectModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using Ex01.FacebookAppLogic.Classes;
using Ex01.FacebookAppUI.Classes;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class FriendsForm : Form
    {
        private User m_LoggedInUser;
        private readonly Thread r_PopulateListViewThread;
        private ImageLoader<User> m_PropertyLoader;

        public FriendsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.m_PropertyLoader = new ImageLoader<User>(this.m_LoggedInUser.Friends, this.friendsListView);
            this.r_PopulateListViewThread = new Thread(() => this.m_PropertyLoader.LoadImageAndTextProperties("ImageLarge", "Name"));
        }

        // PRIVATE METHODS
        private void FriendsForm_Load(object sender, System.EventArgs e)
        {
            this.r_PopulateListViewThread.Start();
        }
    }
}