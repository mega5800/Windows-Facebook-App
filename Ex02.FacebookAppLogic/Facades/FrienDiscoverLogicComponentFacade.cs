using Ex02.FacebookAppLogic.Classes;
using FacebookWrapper.ObjectModel;

namespace Ex02.FacebookAppLogic.Facades
{
    public class FrienDiscoverLogicComponentFacade
    {
        // ATTRIBUTES
        private readonly FrienDiscoverLogicComponent r_FrienDiscoverLogicComponent;

        public FrienDiscoverLogicComponentFacade()
        {
            this.r_FrienDiscoverLogicComponent = new FrienDiscoverLogicComponent();
        }

        // PUBLIC METHODS
        public void PickFirstDegreeAndSecondDegreeFriends(ref User io_ChosenFriendFirstDegree, ref User io_ChosenFriendSecondDegree)
        {
            r_FrienDiscoverLogicComponent.PickFirstDegreeAndSecondDegreeFriends();
            io_ChosenFriendFirstDegree = r_FrienDiscoverLogicComponent.ChosenFriendFirstDegree;
            io_ChosenFriendSecondDegree = r_FrienDiscoverLogicComponent.ChosenFriendSecondDegree;
        }
    }
}