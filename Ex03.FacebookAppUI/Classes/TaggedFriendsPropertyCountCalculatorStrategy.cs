using Ex03.FacebookAppLogic.Classes;
using Ex03.FacebookAppLogic.Interfaces;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace Ex03.FacebookAppUI.Classes
{
    public class TaggedFriendsPropertyCountCalculatorStrategy : IPropertyCountCalculatorStrategy
    {
        // ATTRIBUTES
        private readonly FacebookObjectCollection<Post> r_FacebookObjectCollection;
        private readonly List<PropertyCounter> r_PropertyCounterList;

        // CTOR
        public TaggedFriendsPropertyCountCalculatorStrategy(FacebookObjectCollection<Post> i_FacebookObjectCollection, List<PropertyCounter> i_PropertyCounterList)
        {
            this.r_FacebookObjectCollection = i_FacebookObjectCollection;
            this.r_PropertyCounterList = i_PropertyCounterList;
        }

        public void CalculatePropertyCountValues<T>(T i_FacebookObject, int i_PropertyCountListIndex) where T : FacebookObject
        {
            User userObject = (i_FacebookObject as User);
            PropertyCounter friendPropertyCounterPtr = this.r_PropertyCounterList[i_PropertyCountListIndex];

            foreach (Post post in this.r_FacebookObjectCollection)
            {
                if (post.Message != null && post.Message.Contains(userObject.Name))
                {
                    friendPropertyCounterPtr.Counter++;
                }
            }
        }
    }
}