using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex01.FacebookAppLogic.Classes
{
    public sealed class LoggedInUser
    {
        // ATTRIBUTES
        private static User s_Instance = null;

        // PROPERTIES
        public static User Instance
        {
            get { return s_Instance; }
        }

        // PUBLIC METHODS
        public static void ConvertToLoggedInUserObject(ref LoginResult io_LoginResult)
        {
            if (s_Instance == null)
            {
                s_Instance = io_LoginResult.LoggedInUser;
                io_LoginResult = null;
            }
        }
    }
}