using FacebookWrapper.ObjectModel;

namespace Ex03.FacebookAppLogic.Interfaces
{
    public interface IPropertyCountCalculatorStrategy
    {
        void CalculatePropertyCountValues<T>(T i_FacebookObject, int i_PropertyCountListIndex) where T: FacebookObject;
    }
}