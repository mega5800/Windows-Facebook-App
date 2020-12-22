using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Ex02.FacebookAppUI.Classes;
using Ex02.FacebookAppUI.Enums;
using Ex02.FacebookAppUI.Interfaces;
using Ex02.FacebookAppUI.Loaders;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Forms
{
    public partial class SelectedAlbumForm : Form
    {
        // ATTRIBUTES
        private ILoaderAdapter<Photo> m_LoaderAdapter;
        private string m_AlbumName;
        private FacebookObjectCollection<Photo> m_PhotosAlbum;
        private Loader<Photo> m_ImageLoader;
        
        // CTOR
        public SelectedAlbumForm(FacebookObjectCollection<Photo> i_PhotosAlbum, string i_AlbumName)
        {
            InitializeComponent();
            this.m_LoaderAdapter = new LoaderAdapter<Photo>();
            this.m_PhotosAlbum = i_PhotosAlbum;
            this.m_AlbumName = i_AlbumName;
            this.m_ImageLoader = this.m_LoaderAdapter.FormToLoaderAdapt(eLoaderFactoryContext.CreateImageLoader, this.m_PhotosAlbum, this.selectedAlbumlistView);
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