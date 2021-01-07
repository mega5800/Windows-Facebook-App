using FacebookWrapper.ObjectModel;

namespace Ex03.FacebookAppUI.Loaders
{
    public abstract class Loader<T>
    {
        // ATTRIBUTES
        public FacebookObjectCollection<T> LoaderFacebookObjectCollection { get; set; }

        // CTOR
        public Loader(object i_FacebookObjectCollection)
        {
            this.LoaderFacebookObjectCollection = i_FacebookObjectCollection as FacebookObjectCollection<T>;
        }

        // PROTECTED METHODS
        protected internal abstract void LoadProperties(params string[] i_PropertiesArray);
    }
}