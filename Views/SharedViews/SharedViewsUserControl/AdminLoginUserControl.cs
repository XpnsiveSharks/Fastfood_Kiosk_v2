using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.SharedViews.SharedViewsUserControl
{
    public partial class AdminLoginUserControl : UserControl
    {
        public AdminLoginUserControl()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (this.Parent is Panel panel && panel.FindForm() is MainLoginView mainLogin)
            {
                mainLogin.RemoveLoginUserControl(this);
            }
        }
    }
}
