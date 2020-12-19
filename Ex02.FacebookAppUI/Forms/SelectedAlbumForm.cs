using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Ex02.FacebookAppUI.Enums;
using Ex02.FacebookAppUI.Loaders;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Forms
{
    public partial class SelectedAlbumForm : Form
    {
        // ATTRIBUTES
        private readonly List<object> r_ParamsList;
        private string m_AlbumName;
        private FacebookObjectCollection<Photo> m_PhotosAlbum;
        private Loader<Photo> m_ImageLoader;
        
        // CTOR
        public SelectedAlbumForm(FacebookObjectCollection<Photo> i_PhotosAlbum, string i_AlbumName)
        {
            InitializeComponent();
            this.m_PhotosAlbum = i_PhotosAlbum;
            this.m_AlbumName = i_AlbumName;
            this.r_ParamsList = new List<object>() { this.m_PhotosAlbum, this.selectedAlbumlistView };
            this.m_ImageLoader = LoaderFactory<Photo>.CreateLoader(eLoaderFactoryContext.CreateImageLoader, this.r_ParamsList);
        }

        // EVENTS
        private void SelectedAlbumForm_Load(object sender, System.EventArgs e)
        {
            CenterToScreen();
            this.Text = m_AlbumName;
            new Thread(() => this.m_ImageLoader.LoadProperties("ImageAlbum", "Name")).Start();
        }
    }
}