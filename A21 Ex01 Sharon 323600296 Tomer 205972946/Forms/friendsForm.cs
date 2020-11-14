using FacebookWrapper.ObjectModel;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace A21_Ex01_Sharon_323600296_Tomer_205972946.Forms
{
    public partial class friendsForm : Form
    {
        private User m_LoggedInUser;
        private readonly Thread r_PopulateListViewThread;
        private ImageList m_FriendsPicturesList;
        private const int k_PictureSize = 100;
        private int m_FriendPictureCounter = 0;

        public friendsForm(User i_LoggedInUser)
        {
            InitializeComponent();
            this.m_LoggedInUser = i_LoggedInUser;
            this.m_FriendsPicturesList = new ImageList();
            m_FriendsPicturesList.ImageSize = new Size(k_PictureSize, k_PictureSize);
            m_FriendsPicturesList.ColorDepth = ColorDepth.Depth32Bit;
            this.r_PopulateListViewThread = new Thread(populateFriendsListView);
            this.r_PopulateListViewThread.Start();
        }

        private void populateFriendsListView()
        {
            foreach(User friend in this.m_LoggedInUser.Friends)
            {
                m_FriendsPicturesList.Images.Add(LoadImage(friend.PictureNormalURL));
            }

            friendsListView.LargeImageList = m_FriendsPicturesList;

            foreach (User friend in this.m_LoggedInUser.Friends)
            {
                friendsListView.Items.Add(friend.Name, this.m_FriendPictureCounter);
                this.m_FriendPictureCounter++;
            }
        }

        private Image LoadImage(string i_ImageUrl)
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