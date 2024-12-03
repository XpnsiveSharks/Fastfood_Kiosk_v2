using Fastfood_Kiosk_v2.Configurations;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    public partial class SettingsUserControl : UserControl
    {
       
        internal class DataInsert
        {
            public DatabaseConnection _connection;

            public DataInsert(ConfigurationLoader configurationLoader)
            {
                _connection = new DatabaseConnection(configurationLoader.Configuration);
            }


            public void InsertData(string users_table, string username, string password, string user_role)
            {
                string insertQuery = $"INSERT INTO {users_table} (username,password,user_role) VALUES (@username, @password, @user_role)";

                using (var connection = _connection.GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@user_role", user_role);

                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
        }
        
        public SettingsUserControl()
        {
            InitializeComponent();
        }

        public void test()
        {
            var configLoader = new ConfigurationLoader();
            var datainserter = new DataInsert(configLoader);
            datainserter.InsertData("users_table", Username_Account.Text, Password_Account.Text, UserRole_Account.Text);
        }

        public void showpasstest()
        {
            if(ShowPassword.Checked)
            {
                Password_Account.PasswordChar = '\0';
            }
            else
            {
                Password_Account.PasswordChar = '●';
            }
        }


        private void CreateAccount_Click(object sender, EventArgs e)
        {
            test();
        }



        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            showpasstest();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            

        }
    }
}
