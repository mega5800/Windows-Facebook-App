using FacebookWrapper.ObjectModel;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class FriendsForm : Form
    {
        // check if we can use form_Load
        private User m_LoggedInUser;
        private readonly Thread r_PopulateListViewThread;
        private ImageList m_FriendsPicturesList;
        private readonly Size r_PictureSize = new Size(100,100);
        private int m_FriendPictureCounter = 0;

        public FriendsForm(User i_LoggedInUser)
        {
            InitializeComponent();
            this.m_LoggedInUser = i_LoggedInUser;
            this.m_FriendsPicturesList = new ImageList();
            m_FriendsPicturesList.ImageSize = r_PictureSize;
            m_FriendsPicturesList.ColorDepth = ColorDepth.Depth32Bit;
            this.r_PopulateListViewThread = new Thread(populateFriendsListView);
            this.r_PopulateListViewThread.Start();
        }

        // PRIVATE METHODS
        private void populateFriendsListView()
        {
            foreach (User friend in this.m_LoggedInUser.Friends)
            {
                this.m_FriendsPicturesList.Images.Add(loadImage(friend.PictureNormalURL));
            }

            this.friendsListView.LargeImageList = this.m_FriendsPicturesList;
            foreach (User friend in this.m_LoggedInUser.Friends)
            {
                friendsListView.Items.Add(friend.Name, this.m_FriendPictureCounter);
                this.m_FriendPictureCounter++;
            }
        }

        private Image loadImage(string i_ImageUrl)
        {
            WebRequest request = WebRequest.Create(i_ImageUrl);

            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            Bitmap bmp = new Bitmap(responseStream);
            responseStream.Dispose();

            return bmp;
        }
    }
}