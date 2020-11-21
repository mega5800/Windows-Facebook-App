﻿using Ex01.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ex01.FacebookAppUI.Forms
{
    public partial class FrienDiscoverForm : Form
    {
        // ATTRIBUTES
        private User m_LoggedInUser;
        private User m_ChosenFriendFirstDegree = null;
        private User m_ChosenFriendSecondDegree = null;
        private readonly Random r_RandomFactor;
        private readonly List<int> r_LoggedInUserFriendsIndexList;
        private readonly List<int> r_ChosenFriendFirstDegreeFriendsIndexList;
        private const string k_FirstFriendName = "The system selected your friend {0} to help find new friend!";

        // CTOR
        public FrienDiscoverForm()
        {
            InitializeComponent();
            this.m_LoggedInUser = LoggedInUser.Instance;
            this.r_RandomFactor = new Random();
            this.r_LoggedInUserFriendsIndexList = new List<int>();
            this.r_ChosenFriendFirstDegreeFriendsIndexList = new List<int>();
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

        private void pickFirstDegreeAndSecondDegreeFriends()
        {
            bool isSecondDegreeRandomFriendSelected = false;
            int firstDegreeRandomFriendIndex, secondDegreeRandomFriendIndex;

            fillUserFriendsIndexList(this.m_LoggedInUser, this.r_LoggedInUserFriendsIndexList);
            while (!isSecondDegreeRandomFriendSelected && this.r_LoggedInUserFriendsIndexList.Count > 0)
            {
                firstDegreeRandomFriendIndex = getRandomFriendIndexAndSetValuesToSelectedFriend(this.r_LoggedInUserFriendsIndexList,
                    this.m_LoggedInUser, ref this.m_ChosenFriendFirstDegree);
                fillUserFriendsIndexList(this.m_ChosenFriendFirstDegree, this.r_ChosenFriendFirstDegreeFriendsIndexList);
                this.firstDegreeFriendNameLbl.Text = string.Format(k_FirstFriendName, this.m_ChosenFriendFirstDegree.Name);
                while (!isSecondDegreeRandomFriendSelected && this.r_ChosenFriendFirstDegreeFriendsIndexList.Count > 0)
                {
                    secondDegreeRandomFriendIndex = getRandomFriendIndexAndSetValuesToSelectedFriend(this.r_ChosenFriendFirstDegreeFriendsIndexList,
                        this.m_ChosenFriendFirstDegree, ref this.m_ChosenFriendSecondDegree);
                    isSecondDegreeRandomFriendSelected = checkIfSecondDegreeRandomFriendIsNotLoggedInUser();
                    if (!isSecondDegreeRandomFriendSelected)
                    {
                        this.r_ChosenFriendFirstDegreeFriendsIndexList.Remove(secondDegreeRandomFriendIndex);
                        this.m_ChosenFriendSecondDegree = null;
                    }
                }

                if (this.m_ChosenFriendSecondDegree == null)
                {
                    this.r_LoggedInUserFriendsIndexList.Remove(firstDegreeRandomFriendIndex);
                }
            }

            if (this.m_ChosenFriendSecondDegree == null)
            {
                MessageBox.Show(string.Format("{0}, unfortunately the system couldn't find you a suitable new person to meet :("
                    , this.m_LoggedInUser.FirstName));
            }
            else
            {
                loadPotentialNewFriendDataIntoForm();
            }
        }

        private void loadPotentialNewFriendDataIntoForm()
        {
            this.newFriendAboutLbl.Text = this.m_ChosenFriendSecondDegree.About;
            this.newFriendPictureBox.LoadAsync(this.m_ChosenFriendSecondDegree.PictureNormalURL);
        }

        private bool checkIfSecondDegreeRandomFriendIsNotLoggedInUser()
        {
            bool result = true;

            if (this.m_LoggedInUser.Id == this.m_ChosenFriendSecondDegree.Id)
            {
                result = false;
            }

            return result;
        }

        private int getRandomFriendIndexAndSetValuesToSelectedFriend(List<int> i_UserFriendChooserList, User i_UserFriendChooser, ref User i_ChosenFriendPointer)
        {
            int randomFriendIndex = 0;

            randomFriendIndex = this.r_RandomFactor.Next(0, i_UserFriendChooserList.Count);
            randomFriendIndex = i_UserFriendChooserList[randomFriendIndex];
            i_ChosenFriendPointer = i_UserFriendChooser.Friends[randomFriendIndex];

            return randomFriendIndex;
        }

        // EVENTS
        private void FrienDiscoverForm_Load(object sender, EventArgs e)
        {
            pickFirstDegreeAndSecondDegreeFriends();
        }

        private void getRandomPersonBtn_Click(object sender, EventArgs e)
        {
            pickFirstDegreeAndSecondDegreeFriends();
        }

        private void goToRandomPersonProfileBtn_Click(object sender, EventArgs e)
        {
            Process.Start(string.Format("facebook.com/", this.m_ChosenFriendSecondDegree.UserName));
        }
    }
}