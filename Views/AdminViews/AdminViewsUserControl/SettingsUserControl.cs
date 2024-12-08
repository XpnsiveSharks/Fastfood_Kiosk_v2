using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Fastfood_Kiosk_v2.Views.SharedViews.SharedViewsUserControl.AdminLoginUserControl;

namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    public partial class SettingsUserControl : UserControl
    {
       
        public event Action CreateAccountEventHandler;
        public event Action UpdateAccountEventHandler;
        public event Action DeleteAccountEventHandler;

        public string username { get; set; }

        public SettingsUserControl()
        {
            InitializeComponent();
            username = CurrentUsernameSettings.Text;

            CurrentUsernameSettings.Text = CurrentUser.Username ?? "Not Logged In";
        }

        public void UpdateLoggedInUser()
        {
            CurrentUsernameSettings.Text = CurrentUser.Username ?? "Not Logged In";
        }
        private void CreateAccount_Click(object sender, EventArgs e)
        {
            /*SettingsIndexPanel.Controls.Clear();
            SettingsIndexPanel.Controls.Add(createAccountUserControl);*/
            CreateAccountEventHandler?.Invoke();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            UpdateAccountEventHandler?.Invoke();

        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            DeleteAccountEventHandler?.Invoke();

        }
    
    }
}
