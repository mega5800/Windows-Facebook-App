using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using Ex01.FacebookAppLogic.Classes;
using Ex01.FacebookAppUI.Classes;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class FriendsForm : Form
    {
        // ATTRIBUTES
        private readonly Thread r_StartThread;
        private User m_LoggedInUser;
        private ImageLoader<User> m_ImageLoader;

        // CTOR
        public FriendsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.m_ImageLoader = new ImageLoader<User>(this.m_LoggedInUser.Friends, this.friendsListView);
            this.r_StartThread = new Thread(() => this.m_ImageLoader.LoadImageAndTextProperties("ImageLarge", "Name"));
        }

        // PRIVATE METHODS
        private void FriendsForm_Load(object sender, System.EventArgs e)
        {
            this.r_StartThread.Start();
        }
    }
}