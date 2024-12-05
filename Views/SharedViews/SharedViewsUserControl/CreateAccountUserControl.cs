﻿using Fastfood_Kiosk_v2.Configurations;
using Fastfood_Kiosk_v2.Helpers;
using Fastfood_Kiosk_v2.Views.AdminViews;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Dapper;

namespace Fastfood_Kiosk_v2.Views.SharedViews.SharedViewsUserControl
{
    public partial class CreateAccountUserControl : UserControl
    {
       

        public CreateAccountUserControl()
        {
            InitializeComponent();
        }

        public void ShowPassword_()
        {
            if (ShowPassword.Checked)
            {
                CreatePassword.PasswordChar = '\0';
            }
            else
            {
                CreatePassword.PasswordChar = '●';
            }
        }


        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            string username = CreateUsername.Text;
            string password = CreatePassword.Text;
            string user_role = CreateUserRole.Text;

            PasswordHashing passwordHashing = new PasswordHashing();
          

            try
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and Password cannot be empty.");
                    return;
                }
                string hashedPass = passwordHashing.hashPassword(password);
                passwordHashing.SaveToDatabase(username, hashedPass, user_role);
                MessageBox.Show("Account Has Been Creaed");


            }
            catch (Exception ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

      

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            ShowPassword_();
        }
    }
}
