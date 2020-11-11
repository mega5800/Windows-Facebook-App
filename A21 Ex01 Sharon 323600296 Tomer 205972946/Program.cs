using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace A21_Ex01_Sharon_323600296_Tomer_205972946
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
