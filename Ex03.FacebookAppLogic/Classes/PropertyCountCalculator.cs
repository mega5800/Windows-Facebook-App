using Ex03.FacebookAppLogic.Interfaces;
using FacebookWrapper.ObjectModel;

namespace Ex03.FacebookAppLogic.Classes
{
    public sealed class PropertyCountCalculator
    {
        // ATTRIBUTES
        public IPropertyCountCalculatorStrategy PropertyCountCalculatorStrategy { get; set; }

        // PUBLIC METHODS
        public void CalculatePropertyCountValues<T>(FacebookObjectCollection<T> i_FacebookObjectCollection) where T:FacebookObject
        {
            int index = 0;

            if (i_FacebookObjectCollection.Count > 0)
            {
                foreach (T item in i_FacebookObjectCollection)
                {
                    this.PropertyCountCalculatorStrategy.CalculatePropertyCountValues(item, index);
                    index++;
                }
            }
        }
    }
}