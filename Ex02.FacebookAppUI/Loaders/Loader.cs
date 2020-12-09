using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02.FacebookAppUI.Loaders
{
    public abstract class Loader<T>
    {
        // ATTRIBUTES
        protected readonly FacebookObjectCollection<T> r_FacebookObjectCollection;

        // CTOR
        public Loader(FacebookObjectCollection<T> i_FacebookObjectCollection)
        {
            this.r_FacebookObjectCollection = i_FacebookObjectCollection;
        }

        // PROTECTED METHODS
        protected internal abstract void LoadProperties(params string[] i_TextPropertiesArray);
    }
}