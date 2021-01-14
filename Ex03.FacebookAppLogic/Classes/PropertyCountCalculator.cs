using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace Ex03.FacebookAppLogic.Classes
{
    public sealed class PropertyCountCalculator
    {
        // ATTRIBUTES
        public Func<FacebookObject, FacebookObject, bool> PropertyCountConditionStrategyMethod { get; set; }

        // PUBLIC METHODS
        public void CalculatePropertyCountValues<FacebookObjectType, DistinctFacebookObjectType>(FacebookObjectCollection<FacebookObjectType> i_FacebookObjectCollection, FacebookObjectCollection<DistinctFacebookObjectType> i_DistinctFacebookObjectCollection, List<PropertyCounter> i_PropertyCounterList)
            where FacebookObjectType : FacebookObject
            where DistinctFacebookObjectType : FacebookObject
        {
            int propertyCounterListIndex = 0;

            if (i_FacebookObjectCollection.Count > 0)
            {
                foreach (DistinctFacebookObjectType distinctFacebookObject in i_DistinctFacebookObjectCollection)
                {
                    foreach (FacebookObjectType facebookObject in i_FacebookObjectCollection)
                    {
                        if (this.PropertyCountConditionStrategyMethod(distinctFacebookObject, facebookObject))
                        {
                            i_PropertyCounterList[propertyCounterListIndex].Counter++;
                        }
                    }

                    propertyCounterListIndex++;
                }
            }
        }
    }
}