using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.SharedViews
{
    public partial class CustomerLogin : UserControl
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (this.Parent is Panel panel && panel.FindForm() is MainLogin mainLogin)
            {
                mainLogin.RemoveLoginUserControl(this);
            }
        }
    }
}
