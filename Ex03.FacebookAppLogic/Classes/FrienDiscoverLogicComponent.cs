using System.Collections.Generic;
using Ex03.FacebookAppLogic.Interfaces;
using FacebookWrapper.ObjectModel;

namespace Ex03.FacebookAppLogic.Classes
{
    internal class FrienDiscoverLogicComponent : ISelectable<User>
    {
        // ATTRIBUTES        
        private User m_LoggedInUser;
        private Selector<User> m_Selector;
        private List<User> m_LoggedInUserFriendsList;
        private List<List<User>> m_ChosenFriendFirstDegreeFriendsList;

        public User ChosenFriendFirstDegree { get; private set; }

        public User ChosenFriendSecondDegree { get; private set; }

        public List<User> SelectableObjectsList { get => m_LoggedInUserFriendsList; set => m_LoggedInUserFriendsList = value; }
        public List<List<User>> SelectedObjectLists { get => m_ChosenFriendFirstDegreeFriendsList; set => m_ChosenFriendFirstDegreeFriendsList = value; }

        // CTOR
        public FrienDiscoverLogicComponent()
        {
            this.m_LoggedInUser = LoggedInUser.Instance;

            this.SelectableObjectsList = new List<User>();
            this.SelectedObjectLists = new List<List<User>>();

            fillSelectableObjectsList();
            fillSelectedObjectLists();
            this.m_Selector = new Selector<User>();
            this.m_Selector.SelectedItemsAreTheSameStrategyMethod = (randomUser) => this.m_LoggedInUser.Id == (randomUser as User).Id;
            this.m_Selector.TwoItemsAreConnectedStrategyMethod = checkIfPotentialFriendIsAlreadyMyFriend;
        }

        // PUBLIC METHODS
        public void PickFirstDegreeAndSecondDegreeFriends()
        {
            User firstDegreeFriendPtr = null, secondDegreeFriendPtr = null;
            this.m_Selector.PickFirstDegreeAndSecondDegreeObjects(this, ref firstDegreeFriendPtr, ref secondDegreeFriendPtr);
            ChosenFriendFirstDegree = firstDegreeFriendPtr;
            ChosenFriendSecondDegree = secondDegreeFriendPtr;
        }

        // PRIVATE METHODS
        private bool checkIfPotentialFriendIsAlreadyMyFriend(User i_UserToCheck)
        {
            bool result = false;

            foreach (User friend in this.m_LoggedInUser.Friends)
            {
                if (i_UserToCheck.Id == friend.Id)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        private void fillSelectableObjectsList()
        {
            foreach (User friend in this.m_LoggedInUser.Friends)
            {
                this.SelectableObjectsList.Add(friend);
            }
        }

        private void fillSelectedObjectLists()
        {
            int listCounter = 0;

            foreach (User friend in this.m_LoggedInUser.Friends)
            {
                this.SelectedObjectLists.Add(new List<User>());
                foreach (User secondDegreeFriend in friend.Friends)
                {
                    this.SelectedObjectLists[listCounter].Add(secondDegreeFriend);
                }

                listCounter++;
            }
        }
    }
}