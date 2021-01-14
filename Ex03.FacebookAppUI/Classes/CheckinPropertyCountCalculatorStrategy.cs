using Ex03.FacebookAppLogic.Classes;
using Ex03.FacebookAppLogic.Interfaces;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace Ex03.FacebookAppUI.Classes
{
    public class CheckinPropertyCountCalculatorStrategy : IPropertyCountCalculatorStrategy
    {
        // ATTRIBUTES
        private readonly FacebookObjectCollection<Checkin> r_FacebookObjectCollection;
        private readonly List<PropertyCounter> r_PropertyCounterList;

        // CTOR
        public CheckinPropertyCountCalculatorStrategy(FacebookObjectCollection<Checkin> i_FacebookObjectCollection, List<PropertyCounter> i_PropertyCounterList)
        {
            this.r_FacebookObjectCollection = i_FacebookObjectCollection;
            this.r_PropertyCounterList = i_PropertyCounterList;
        }

        // IPROPERTYCOUNTCALCULATORSTRATEGY IMPLEMENTATION
        public void CalculatePropertyCountValues<T>(T i_FacebookObject, int i_PropertyCountListIndex) where T : FacebookObject
        {
            Checkin checkinObject = (i_FacebookObject as Checkin);
            PropertyCounter checkinPropertyCounterPtr = this.r_PropertyCounterList[i_PropertyCountListIndex];

            foreach (Checkin checkin in this.r_FacebookObjectCollection)
            {
                if (checkinObject.Place.Location.Country == checkin.Place.Location.Country)
                {
                    checkinPropertyCounterPtr.Counter++;
                }
            }
        }
    }
}