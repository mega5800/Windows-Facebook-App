using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Ex03.FacebookAppUI.Loaders
{
    public sealed class ImageLoader<T> : Loader<T>
    {
        // ATTRIBUTES
        private readonly ImageList r_ImagesList;
        private readonly Size r_PictureSize = new Size(100, 100);
        private ListView m_ListView;
        private int m_FriendPictureCounter = 0;
        private PropertyInfo m_PropertyInfo;
        private object m_PropertyInfoObject;

        // CTOR
        public ImageLoader(List<object> i_ParamsList) : base(i_ParamsList[0])
        {
            this.m_ListView = i_ParamsList[1] as ListView;
            this.r_ImagesList = new ImageList();
            this.r_ImagesList.ImageSize = r_PictureSize;
            this.r_ImagesList.ColorDepth = ColorDepth.Depth32Bit;
        }

        // PROTECTED METHODS
        protected internal override void LoadProperties(params string[] i_PropertiesArray)
        {
            loadImages(i_PropertiesArray[0]);
            loadTexts(i_PropertiesArray[1]);
        }

        // PRIVATE METHODS
        private void loadImages(string i_ImageProperty)
        {
            foreach (T item in this.r_FacebookObjectCollection)
            {
                setReflectionResultIntoPropertyInfoObject(item, i_ImageProperty);
                this.m_ListView.Invoke(new Action(() => this.r_ImagesList.Images.Add((Image)this.m_PropertyInfoObject)));
            }

            this.m_ListView.Invoke(new Action(() => this.m_ListView.LargeImageList = this.r_ImagesList));
        }

        private void loadTexts(string i_TextProperty)
        {
            foreach (T item in this.r_FacebookObjectCollection)
            {
                setReflectionResultIntoPropertyInfoObject(item, i_TextProperty);
                this.m_ListView.Invoke(new Action(() => this.m_ListView.Items.Add((string)this.m_PropertyInfoObject, this.m_FriendPictureCounter)));
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