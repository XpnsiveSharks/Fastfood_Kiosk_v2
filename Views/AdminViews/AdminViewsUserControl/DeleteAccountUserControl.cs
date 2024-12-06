using Fastfood_Kiosk_v2.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    public partial class DeleteAccountUserControl : UserControl
    {
        private readonly UsersRepository usersRepository = new UsersRepository();
      

        public DeleteAccountUserControl()
        {
            InitializeComponent();

        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            string username = DeleteUsername.Text; 
            string password = DeletePassword.Text; 

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and Password are required to delete an account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmation = MessageBox.Show(
                $"Are you sure you want to delete the account for '{username}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    bool isDeleted = usersRepository.DeleteUser(username, password);

                    if (isDeleted)
                    {

                        MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SettingsUserControl settings = new SettingsUserControl();
                        settings.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Deletion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                DeletePassword.PasswordChar = '\0';
            }
            else
            {
                DeletePassword.PasswordChar = '●';
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
        
        }
    }
}
