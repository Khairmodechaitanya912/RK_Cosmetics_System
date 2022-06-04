using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RK_Cosmetics_System.Report;
using RK_Cosmetics_System.Other;

namespace RK_Cosmetics_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.b 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Splash_Screen());
            //Application.Run(new Stock_Report());
            //Application.Run(new frm_Main_Report());
        }
    }
}
