using Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.Customer
{
    public partial class CustomerMainFrameView : Form
    {
        private readonly Dictionary<string, UserControl> _userControls = new Dictionary<string, UserControl>();
        public CustomerMainFrameView()
        {
            InitializeComponent();
            ShowOrderingUserControl();
        } 
        public void ShowOrderTypeUserControl()
        {
            LoadUserControl("Order Type", () => new OrderTypeUserControl());
        }
        public void ShowOrderingUserControl()
        {
            LoadUserControl("Customer Ordering", () => new CustomerOrderingUserControl());
        }
        private void LoadUserControl(string key, Func<UserControl> createControl)
        {
            if (!_userControls.ContainsKey(key))
                _userControls[key] = createControl();

            var userControl = _userControls[key];
            userControl.Dock = DockStyle.Fill;
            CustomerMainFramePanel.Controls.Clear();
            CustomerMainFramePanel.Controls.Add(userControl);
        }
    }
}
