using Ex01.FacebookAppUI.Forms;
using System;
using System.Windows.Forms;

namespace Ex01.FacebookAppUI.Classes
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Form startingFormPointer = null;
            AppSettings appSettings = AppSettings.Instance;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (appSettings.RememberUser && !string.IsNullOrEmpty(appSettings.LastAccessToken))
            {
                startingFormPointer = new MainForm(appSettings);
            }
            else
            {
                startingFormPointer = new LoginForm(appSettings);
            }

            Application.Run(startingFormPointer);
        }
    }
}