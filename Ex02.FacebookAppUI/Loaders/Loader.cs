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
        public Loader(object i_FacebookObjectCollection)
        {
            this.r_FacebookObjectCollection = i_FacebookObjectCollection as FacebookObjectCollection<T>;
        }

        // PROTECTED METHODS
        protected internal abstract void LoadProperties(params string[] i_PropertiesArray);
    }
}