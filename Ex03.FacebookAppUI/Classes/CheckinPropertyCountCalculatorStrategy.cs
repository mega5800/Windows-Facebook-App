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

        public void CalculatePropertyCountValues<T>(T i_FacebookObject, int i_PropertyCountListIndex) where T : FacebookObject
        {
            Checkin checkinObject = (i_FacebookObject as Checkin);
        }
    }
}