using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DashboradWinForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {//Enable custom sql queries for the dashboard data source wizard
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DesignerForm1 designer1 = new DesignerForm1();
            Application.Run(designer1);
        }
    }
}
