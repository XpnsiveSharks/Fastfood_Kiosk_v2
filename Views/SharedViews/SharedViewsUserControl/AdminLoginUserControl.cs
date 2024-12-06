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
    public partial class AdminLoginUserControl : UserControl
    {
        public string UserRole {  get; set; }
        ValidateCredentials validateCreds = new ValidateCredentials();
        public AdminLoginUserControl(string userRole)
        {
            InitializeComponent();
            UserRole = userRole;
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            if (this.Parent is Panel panel && panel.FindForm() is MainLoginView mainLogin)
            {
                mainLogin.RemoveLoginUserControl(this);
            }
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {

            try
            {
                string username = AdminUsernameTextBox.Text;
                string password = AdminPasswordTextBox.Text;                

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and Password cannot be empty.");
                    return;
                }
                if (validateCreds.validateCredentials(username, password, UserRole))
                {
                    AdminIndexView adminIndexView = new AdminIndexView();
                    adminIndexView.Show();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }*/
        }
    }
}


/*try
{
    string username = AdminUsernameTextBox.Text;
    string password = AdminPasswordTextBox.Text;

    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
    {
        MessageBox.Show("Username and Password cannot be empty.");
        return;
    }
    string hashedPass = passwordHashing.hashPassword(password);
    passwordHashing.SaveToDatabase(username, hashedPass);
    AdminIndexView adminIndexView = new AdminIndexView();
    adminIndexView.Show();

}
catch (Exception ex)
{
    throw new Exception("An error has occured while accessing the database", ex);
}*/