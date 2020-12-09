using Ex02.FacebookAppUI.Enums;
using System.Collections.Generic;

namespace Ex02.FacebookAppUI.Loaders
{
    public static class LoaderFactory<T>
    {
        public static Loader<T> CreateLoader(eLoaderFactoryContext i_LoaderFactoryContext, List<object> i_ParamsList)
        {
            Loader<T> loaderToReturn = null;

            switch (i_LoaderFactoryContext)
            {
                case eLoaderFactoryContext.CreateImageLoader:
                    loaderToReturn = new ImageLoader<T>(i_ParamsList);
                    break;
                case eLoaderFactoryContext.CreateTextLoader:
                    loaderToReturn = new TextLoader<T>(i_ParamsList);
                    break;
            }

            return loaderToReturn;
        }
    }
}