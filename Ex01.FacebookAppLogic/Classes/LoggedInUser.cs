using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Ex01.FacebookAppLogic.Classes
{
    public sealed class LoggedInUser
    {
        private static readonly object sr_LockContext = new object();
        private static User s_Instance = null;

        private LoggedInUser()
        {
        }

        public static User Instance
        {
            get { return s_Instance; }
        }

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