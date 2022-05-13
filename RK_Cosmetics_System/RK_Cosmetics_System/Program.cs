using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RK_Cosmetics_System.Report;

namespace RK_Cosmetics_System
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
            Application.Run(new frm_Login_Form());
           // Application.Run(new Stock_Details_Report());
        }
    }
}
