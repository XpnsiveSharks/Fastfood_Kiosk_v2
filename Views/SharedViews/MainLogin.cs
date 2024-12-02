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
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        private void CustomerLoginButton_Click(object sender, EventArgs e)
        {
            ShowLoginUserControl(new CustomerLogin());
        }
        private void StaffLoginButton_Click(object sender, EventArgs e)
        {
            ShowLoginUserControl(new StaffLogin());

        }
        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            ShowLoginUserControl(new AdminLogin());

        }
        private void ShowLoginUserControl(UserControl userControl)
        {
            foreach(Control control in LoginPanel.Controls)
            {
                control.Visible = false;
            }
            userControl.Dock = DockStyle.Fill;
            LoginPanel.Controls.Add(userControl);
        }

        public void RemoveLoginUserControl(UserControl userControl)
        {
            LoginPanel.Controls.Remove(userControl);
            
            foreach (Control control in LoginPanel.Controls)
            {
                control.Visible = true;
            }
        }

    }
}
