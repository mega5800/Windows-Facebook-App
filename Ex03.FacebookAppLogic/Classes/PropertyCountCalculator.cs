using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Ex03.FacebookAppLogic.Classes
{
    public delegate R Func<T, T1, R>(T i_ItemToCheck, ref T1 io_UniqueItem);

    public sealed class PropertyCountCalculator<T>
    {
        // ATTRIBUTES
        private readonly FacebookObjectCollection<T> r_FacebookObjectCollection;
        private readonly List<PropertyCounter> r_PropertyCounterList;

        public event Func<T, string, bool> DuplicatePropertyCheckingMethodIsNeeded;

        // CTOR
        public PropertyCountCalculator(FacebookObjectCollection<T> i_FacebookObjectCollection, List<PropertyCounter> i_PropertyCounterList)
        {
            this.r_FacebookObjectCollection = i_FacebookObjectCollection;
            this.r_PropertyCounterList = i_PropertyCounterList;
        }

        // PUBLIC METHODS
        public void CalculatePropertyCountValues()
        {
            bool checkingMethodResult;
            string propertyNameAndCounterStringFormat = string.Empty, uniquePropertyString = string.Empty;

            if (this.r_FacebookObjectCollection.Count > 0)
            {
                foreach (T item in this.r_FacebookObjectCollection)
                {
                    checkingMethodResult = this.DuplicatePropertyCheckingMethodIsNeeded(item, ref uniquePropertyString);
                    if (checkingMethodResult)
                    {
                        this.r_PropertyCounterList.Add(new PropertyCounter(uniquePropertyString));
                    }
                }
            }
        }
    }
}