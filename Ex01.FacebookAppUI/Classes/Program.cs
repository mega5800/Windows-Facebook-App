﻿using System;
using System.Windows.Forms;
using Ex02.FacebookAppUI.Forms;

namespace Ex02.FacebookAppUI.Classes
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
                startingFormPointer = new MainForm();
            }
            else
            {
                startingFormPointer = new LoginForm();
            }

            Application.Run(startingFormPointer);
        }
    }
}