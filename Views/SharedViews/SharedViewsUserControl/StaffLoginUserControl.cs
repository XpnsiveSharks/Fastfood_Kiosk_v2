using Fastfood_Kiosk_v2.Helpers;
using Fastfood_Kiosk_v2.Views.AdminViews;
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
    public partial class StaffLoginUserControl : UserControl
    {
        public StaffLoginUserControl()
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

        private void StaffLoginButton_Click(object sender, EventArgs e)
        {
            PasswordHashing passwordHashing = new PasswordHashing();

            try
            {
                string username = StaffUsernameTextBox.Text;
                string pasword = StaffPasswordTextBox.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pasword))
                {
                    MessageBox.Show("Username and Password cannot be empty.");
                    return;
                }
                string hashedPass = passwordHashing.hashPassword(pasword);
                passwordHashing.SaveToDatabase(username, hashedPass);
                AdminIndexView adminIndexView = new AdminIndexView();
                adminIndexView.Show();

            }
            catch (Exception ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }
    }
}
