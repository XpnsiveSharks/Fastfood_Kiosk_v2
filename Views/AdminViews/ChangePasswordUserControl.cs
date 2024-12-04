using Fastfood_Kiosk_v2.Configurations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.AdminViews
{
    public partial class ChangePasswordUserControl : UserControl
    {


        internal class UpdateAccount
        {
            public DatabaseConnection _connection;

            public UpdateAccount(ConfigurationLoader configurationLoader)
            {
                _connection = new DatabaseConnection(configurationLoader.Configuration);
            }


        }

        //note basta i update yung password 
        //how yung password na nasa database yun yung kukunin mong parang reference as id para mag match sila sa db <3 
        //gawin mo dagsa susuntukin kita diyan
        public void updateAccount()
        {
            string UpdateQuery = "UPDATE fastfood_kiosk_v1_database.Users_table SET password = ";
        }

        public ChangePasswordUserControl()
        {
            InitializeComponent();
        }
    }
}
