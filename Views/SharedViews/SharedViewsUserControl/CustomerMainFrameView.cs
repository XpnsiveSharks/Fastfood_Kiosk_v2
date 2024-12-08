 using Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.Customer
{
    public partial class CustomerMainFrameView : Form
    {
        private readonly Dictionary<string, UserControl> _userControls = new Dictionary<string, UserControl>();
        public CustomerMainFrameView()
        {
            InitializeComponent();
            ShowOrderTypeUserControl();
        }
        public void ShowOrderTypeUserControl()
        {
            if (!_userControls.TryGetValue("Order Type", out UserControl userControl))
            {
                var orderTypeUserControl = new OrderTypeUserControl();
                orderTypeUserControl.OrderTypeChanged += orderType =>
                {
                    ShowOrderingUserControl(orderType); 
                };
                _userControls["Order Type"] = orderTypeUserControl;
            }

            LoadUserControl("Order Type");
        }
        public void ShowOrderingUserControl(string orderType)
        {
            if (!_userControls.ContainsKey("Customer Ordering"))
            {
                _userControls["Customer Ordering"] = new CustomerOrderingUserControl(orderType);
            }

            LoadUserControl("Customer Ordering");
        }

        private void LoadUserControl(string key)
        {
            if (_userControls.TryGetValue(key, out var userControl))
            {
                userControl.Dock = DockStyle.Fill;
                CustomerMainFramePanel.Controls.Clear();
                CustomerMainFramePanel.Controls.Add(userControl);
            }
        }
    }
}
