using FacebookWrapper.ObjectModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using Ex01.FacebookAppLogic.Classes;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class FriendsForm : Form
    {
        // check if we can use form_Load
        private User m_LoggedInUser;
        private readonly Thread r_PopulateListViewThread;
        private readonly ImageList m_FriendsPicturesList;
        private readonly Size r_PictureSize = new Size(100,100);
        private int m_FriendPictureCounter = 0;

        public FriendsForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.m_FriendsPicturesList = new ImageList();
            m_FriendsPicturesList.ImageSize = r_PictureSize;
            m_FriendsPicturesList.ColorDepth = ColorDepth.Depth32Bit;
            this.r_PopulateListViewThread = new Thread(new ThreadStart(populateFriendsListView));
            this.r_PopulateListViewThread.Start();
            //populateFriendsListView();
        }

        // PRIVATE METHODS
        private void populateFriendsListView()
        {
            foreach (User friend in this.m_LoggedInUser.Friends)
            {
                this.m_FriendsPicturesList.Images.Add(friend.ImageLarge);
            }

            this.friendsListView.LargeImageList = this.m_FriendsPicturesList;
            foreach (User friend in this.m_LoggedInUser.Friends)
            {
                friendsListView.Items.Add(friend.Name, this.m_FriendPictureCounter);
                this.m_FriendPictureCounter++;
            }
        }
    }
}