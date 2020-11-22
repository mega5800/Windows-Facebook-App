using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex01.FacebookAppLogic.Classes
{
    public sealed class LoggedInUser
    {
        // ATTRIBUTES
        private static readonly object sr_LockContext = new object();
        private static User s_Instance = null;

        // CTOR
        private LoggedInUser()
        {
        }

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
                lock (sr_LockContext)
                {
                    if (s_Instance == null)
                    {
                        s_Instance = io_LoginResult.LoggedInUser;
                        io_LoginResult = null;
                    }
                }
            }
        }
    }
}