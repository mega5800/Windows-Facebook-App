using Ex03.FacebookAppLogic.Classes;
using Ex03.FacebookAppLogic.Interfaces;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace Ex03.FacebookAppUI.Classes
{
    public class CheckinPropertyCountCalculatorStrategy : IPropertyCountCalculatorStrategy
    {
        private readonly FacebookObjectCollection<Checkin> r_FacebookObjectCollection;
        private readonly List<PropertyCounter> r_PropertyCounterList;

        public CheckinPropertyCountCalculatorStrategy(FacebookObjectCollection<Checkin> i_FacebookObjectCollection, List<PropertyCounter> i_PropertyCounterList)
        {
            this.r_FacebookObjectCollection = i_FacebookObjectCollection;
            this.r_PropertyCounterList = i_PropertyCounterList;
        }

        void IPropertyCountCalculatorStrategy.CalculatePropertyCountValues<Checkin>(Checkin i_FacebookObject, int i_PropertyCountListIndex)
        {

            /*foreach (Checkin checkin in this.r_FacebookObjectCollection)
            {
                if 
                //locationCounter.PropertyName == i_CheckinToCheck.Place.Location.Country
            }*/
        }
    }
}