using Fastfood_Kiosk_v2.Models;
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
    public partial class UpdateAccountUserControl : UserControl
    {
        private readonly UsersRepository usersRepository = new UsersRepository();
        private readonly Users users = new Users();
        public event Action BackSettingsUserControltEventHandler;

        public UpdateAccountUserControl()
        {
            InitializeComponent();
        }
        private void UpdateAccount_Click(object sender, EventArgs e)
        {

            string currentPassword = CurrentPassword.Text;
            string newPassword = NewPassword.Text;
            string confirmPassword = ConfirmPassword.Text;

            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirmation password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UsersRepository usersRepository = new UsersRepository();
            bool isUpdated = usersRepository.UpdateUsers(currentPassword, newPassword);

            if (isUpdated)
            {
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid current password. Update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BackSettingsUserControltEventHandler?.Invoke();
        }


        private void ShowNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowNewPassword.Checked)
            {
                NewPassword.PasswordChar = '\0';
            }
            else
            {
                NewPassword.PasswordChar = '●';
            }
        }

        private void ShowCurrentPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (ShowConfirmPassword.Checked)
            {
                ConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                ConfirmPassword.PasswordChar = '●';
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            BackSettingsUserControltEventHandler?.Invoke();

        }
    }
}
