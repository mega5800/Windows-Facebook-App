using Ex02.FacebookAppUI.Enums;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace Ex02.FacebookAppUI.Loaders
{
    public static class LoaderFactory<T>
    {
        public static Loader<T> CreateLoader(eLoaderFactoryContext i_LoaderFactoryContext, FacebookObjectCollection<T> i_FacebookObjectCollection, Control i_Control, string i_StringFormat)
        {
            Loader<T> loaderToReturn = null;

            switch (i_LoaderFactoryContext)
            {
                case eLoaderFactoryContext.CreateImageLoader:
                    loaderToReturn = new ImageLoader<T>(i_FacebookObjectCollection, i_Control as ListView);
                    break;
                case eLoaderFactoryContext.CreateTextLoader:
                    loaderToReturn = new TextLoader<T>(i_FacebookObjectCollection, i_Control as ListBox, i_StringFormat);
                    break;
            }

            return loaderToReturn;
        }
    }
}