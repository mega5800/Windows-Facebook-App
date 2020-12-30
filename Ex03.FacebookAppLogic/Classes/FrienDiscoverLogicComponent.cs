using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Ex03.FacebookAppLogic.Classes
{
    internal class FrienDiscoverLogicComponent
    {
        // ATTRIBUTES
        private readonly List<int> r_LoggedInUserFriendsIndexList;
        private readonly List<int> r_ChosenFriendFirstDegreeFriendsIndexList;
        private readonly Random r_RandomFactor;
        private User m_LoggedInUser;

        public User ChosenFriendFirstDegree { get; private set; }

        public User ChosenFriendSecondDegree { get; private set; }

        // CTOR
        public FrienDiscoverLogicComponent()
        {
            ChosenFriendFirstDegree = null;
            ChosenFriendSecondDegree = null;
            this.r_RandomFactor = new Random();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.r_LoggedInUserFriendsIndexList = new List<int>();
            this.r_ChosenFriendFirstDegreeFriendsIndexList = new List<int>();
        }

        // PUBLIC METHODS
        public void PickFirstDegreeAndSecondDegreeFriends()
        {
            User chosenFriendPointer = null;
            bool isSecondDegreeRandomFriendSelected = false;
            int firstDegreeRandomFriendIndex, secondDegreeRandomFriendIndex;

            fillUserFriendsIndexList(this.m_LoggedInUser, this.r_LoggedInUserFriendsIndexList);
            while (!isSecondDegreeRandomFriendSelected && this.r_LoggedInUserFriendsIndexList.Count > 0)
            {
                chosenFriendPointer = ChosenFriendFirstDegree;
                firstDegreeRandomFriendIndex = getRandomFriendIndexAndSetValuesToSelectedFriend(this.r_LoggedInUserFriendsIndexList, this.m_LoggedInUser, ref chosenFriendPointer);
                ChosenFriendFirstDegree = chosenFriendPointer;
                fillUserFriendsIndexList(ChosenFriendFirstDegree, this.r_ChosenFriendFirstDegreeFriendsIndexList);
                while (!isSecondDegreeRandomFriendSelected && this.r_ChosenFriendFirstDegreeFriendsIndexList.Count > 0)
                {
                    chosenFriendPointer = ChosenFriendSecondDegree;
                    secondDegreeRandomFriendIndex = getRandomFriendIndexAndSetValuesToSelectedFriend(this.r_ChosenFriendFirstDegreeFriendsIndexList, ChosenFriendFirstDegree, ref chosenFriendPointer);
                    ChosenFriendSecondDegree = chosenFriendPointer;
                    isSecondDegreeRandomFriendSelected = checkIfSecondDegreeRandomFriendIsNotLoggedInUser();
                    if (!isSecondDegreeRandomFriendSelected || checkIfPotentialFriendIsAlreadyMyFriend())
                    {
                        this.r_ChosenFriendFirstDegreeFriendsIndexList.Remove(secondDegreeRandomFriendIndex);
                        ChosenFriendSecondDegree = null;
                    }
                }

                if (ChosenFriendSecondDegree == null)
                {
                    this.r_LoggedInUserFriendsIndexList.Remove(firstDegreeRandomFriendIndex);
                }
            }
        }

        // PRIVATE METHODS
        private void fillUserFriendsIndexList(User i_User, List<int> i_ListToFill)
        {
            i_ListToFill.Clear();
            for (int i = 0; i < i_User.Friends.Count; i++)
            {
                i_ListToFill.Add(i);
            }
        }

        private int getRandomFriendIndexAndSetValuesToSelectedFriend(List<int> i_UserFriendChooserList, User i_UserFriendChooser, ref User io_ChosenFriendPointer)
        {
            int randomFriendIndex = 0;

            randomFriendIndex = this.r_RandomFactor.Next(0, i_UserFriendChooserList.Count);
            randomFriendIndex = i_UserFriendChooserList[randomFriendIndex];
            io_ChosenFriendPointer = i_UserFriendChooser.Friends[randomFriendIndex];

            return randomFriendIndex;
        }

        private bool checkIfPotentialFriendIsAlreadyMyFriend()
        {
            bool result = false;

            foreach (User friend in this.m_LoggedInUser.Friends)
            {
                if (ChosenFriendSecondDegree.Id == friend.Id)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        private bool checkIfSecondDegreeRandomFriendIsNotLoggedInUser()
        {
            bool result = true;

            if (this.m_LoggedInUser.Id == ChosenFriendSecondDegree.Id)
            {
                result = false;
            }

            return result;
        }
    }
}