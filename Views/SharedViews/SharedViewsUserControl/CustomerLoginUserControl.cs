using Dapper;
using Fastfood_Kiosk_v2.Configurations;
using Fastfood_Kiosk_v2.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.SharedViews.SharedViewsUserControl
{
    public partial class CustomerLoginUserControl : UserControl
    {

        public CustomerLoginUserControl()
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

        private void CustomerLoginButton_Click(object sender, EventArgs e)
        {
           /* PasswordHashing passwordHashing = new PasswordHashing();

            try
            {
                string username = CustomerUsernameTextBox.Text;
                string pasword = CustomerPasswordTextBox.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pasword))
                {
                    MessageBox.Show("Username and Password cannot be empty.");
                    return;
                }
                string hashedPass = passwordHashing.hashPassword(pasword);
                passwordHashing.SaveToDatabase(username, hashedPass);

            }
            catch (Exception ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }*/

        }
    }
}
