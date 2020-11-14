using FacebookWrapper.ObjectModel;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace A21_Ex01_Sharon_323600296_Tomer_205972946.Forms
{
    public partial class friendsForm : Form
    {
        private User m_LoggedInUser;

        public friendsForm(User i_LoggedInUser)
        {
            InitializeComponent();
            this.m_LoggedInUser = i_LoggedInUser;

            PopulateListView();
        }

        private void PopulateListView()
        {
            int counter = 0;
            ImageList images = new ImageList();
            images.ImageSize = new Size(100, 100);

            this.m_LoggedInUser.ReFetch();
            foreach(User friend in this.m_LoggedInUser.Friends)
            {
                images.Images.Add(LoadImage(friend.PictureNormalURL));
            }

            friendsListView.LargeImageList = images;

            foreach (User friend in this.m_LoggedInUser.Friends)
            {
                friendsListView.Items.Add(friend.Name, counter);
                counter++;
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