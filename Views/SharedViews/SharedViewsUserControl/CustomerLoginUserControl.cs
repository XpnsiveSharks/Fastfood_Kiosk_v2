using Dapper;
using Fastfood_Kiosk_v2.Configurations;
using Fastfood_Kiosk_v2.Helpers;
using Fastfood_Kiosk_v2.Views.AdminViews;
using Fastfood_Kiosk_v2.Views.Customer;
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
        private readonly CustomerMainFrameView customerMainFrameView = new CustomerMainFrameView();
        public string UserRole { get; set; }
        ValidateCredentials validateCreds = new ValidateCredentials();
        public CustomerLoginUserControl(string userRole)
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

        private void CustomerLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = CustomerUsernameTextBox.Text;
                string password = CustomerPasswordTextBox.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and Password cannot be empty.");
                    return;
                }
                if (validateCreds.validateCredentials(username, password, "customer"))
                {
                    customerMainFrameView.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username and password", "Error");
                }

            }
            catch (Exception ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }

        }
    }
    
}
