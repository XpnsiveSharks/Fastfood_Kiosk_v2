using Fastfood_Kiosk_v2.Views.AdminViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Views.Customer.CustomerMainFrameView());
            //Application.Run(new Views.SharedViews.MainLoginView());
            //Application.Run(new Views.AdminViews.AdminIndexView());


        }
    }
}
