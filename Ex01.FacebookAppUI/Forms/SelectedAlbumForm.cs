using FacebookWrapper.ObjectModel;
using System.Drawing;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class SelectedAlbumForm : Form
    {
        private FacebookObjectCollection<Photo> m_PhotosAlbum;
        // code copy!!!!
        private ImageList m_AlbumPhotosList;
        private string m_AlbumName;
        private readonly Size r_PictureSize = new Size(100, 100);
        private int m_PhotoCounter = 0;

        public SelectedAlbumForm(FacebookObjectCollection<Photo> i_PhotosAlbum, string i_AlbumName)
        {
            InitializeComponent();
            this.m_PhotosAlbum = i_PhotosAlbum;
            this.m_AlbumPhotosList = new ImageList();
            m_AlbumPhotosList.ImageSize = r_PictureSize;
            m_AlbumPhotosList.ColorDepth = ColorDepth.Depth32Bit;
            this.m_AlbumName = i_AlbumName;
        }

        private void SelectedAlbumForm_Load(object sender, System.EventArgs e)
        {
            CenterToScreen();
            this.Text = m_AlbumName;
            foreach (Photo photo in this.m_PhotosAlbum)
            {
                this.m_AlbumPhotosList.Images.Add(photo.ImageNormal);
            }

            this.selectedAlbumlistView.LargeImageList = this.m_AlbumPhotosList;
            foreach (Photo photo in this.m_PhotosAlbum)
            {
                this.selectedAlbumlistView.Items.Add(photo.Name, this.m_PhotoCounter);
                this.m_PhotoCounter++;
            }
        }
    }
}