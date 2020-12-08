using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppUI.Classes
{
    public sealed class ImageLoader<T>
    {
        // ATTRIBUTES
        private readonly ImageList r_ImagesList;
        private readonly Size r_PictureSize = new Size(100, 100);
        private readonly FacebookObjectCollection<T> r_FacebookObjectCollection;
        private ListView m_ListView;
        private int m_FriendPictureCounter = 0;
        private PropertyInfo m_PropertyInfo;
        private object m_PropertyInfoObject;

        // CTOR
        public ImageLoader(FacebookObjectCollection<T> i_FacebookObjectCollection, ListView i_ListView)
        {
            this.r_FacebookObjectCollection = i_FacebookObjectCollection;
            this.m_ListView = i_ListView;
            this.r_ImagesList = new ImageList();
            this.r_ImagesList.ImageSize = r_PictureSize;
            this.r_ImagesList.ColorDepth = ColorDepth.Depth32Bit;
        }

        // PUBLIC METHODS
        public void LoadImageAndTextProperties(string i_ImageProperty, string i_TextProperty)
        {
            loadImages(i_ImageProperty);
            loadTexts(i_TextProperty);
        }

        // PRIVATE METHODS
        private void loadImages(string i_ImageProperty)
        {
            foreach (T item in this.r_FacebookObjectCollection)
            {
                setReflectionResultIntoPropertyInfoObject(item, i_ImageProperty);
                this.r_ImagesList.Images.Add((Image)this.m_PropertyInfoObject);
            }

            this.m_ListView.LargeImageList = this.r_ImagesList;
        }

        private void loadTexts(string i_TextProperty)
        {
            foreach (T item in this.r_FacebookObjectCollection)
            {
                setReflectionResultIntoPropertyInfoObject(item, i_TextProperty);
                this.m_ListView.Items.Add((string)this.m_PropertyInfoObject, this.m_FriendPictureCounter);
                this.m_FriendPictureCounter++;
            }
        }

        private void setReflectionResultIntoPropertyInfoObject(T i_Item, string i_PropertyName)
        {
            this.m_PropertyInfo = i_Item.GetType().GetProperty(i_PropertyName);
            this.m_PropertyInfoObject = this.m_PropertyInfo.GetValue(i_Item, null);
        }
    }
}