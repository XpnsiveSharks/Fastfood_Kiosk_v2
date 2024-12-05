using Dapper;
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
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    public partial class SettingsUserControl : UserControl
    {
        
        private readonly CreateAccountUserControl createAccountUserControl = new CreateAccountUserControl();
        private readonly UpdateAccountUserControl updateAccountUserControl = new UpdateAccountUserControl();
        public SettingsUserControl()
        {
            InitializeComponent();
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            SettingsIndexPanel.Controls.Clear();
            SettingsIndexPanel.Controls.Add(createAccountUserControl);

        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            SettingsIndexPanel.Controls.Clear();
            SettingsIndexPanel.Controls.Add(updateAccountUserControl);
        }
    }
}
