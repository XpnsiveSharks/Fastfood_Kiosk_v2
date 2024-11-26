using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views
{
    internal static class NavigationManager
    {
        public static Panel MainPanel { get; set; }
        public static void Navigate(UserControl userControl)
        {
            if (MainPanel == null)
                throw new InvalidOperationException("MainPanel is not set. Assign it before navigating");
            MainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(userControl);
        }
    }
}
