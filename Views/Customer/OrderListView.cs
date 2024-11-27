using Fastfood_Kiosk_v2.ViewModels;
using Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl;
using Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.Customer
{
    public partial class OrderListView : Form
    {

        OrderListUserControl orderListUserControl;

        public OrderListView()
        {
            InitializeComponent();
        }

        public void displaytest()
        {
            orderListUserControl = new OrderListUserControl();
            OrderListFlowLayoutPanel.Controls.Add(orderListUserControl);

            if (orderListUserControl.Controls.Count > 1)
            {
                OrderListFlowLayoutPanel.Controls.Clear();
            }
            //infinite nadadagdag busit
        }
        private void AddMoreButton_Click(object sender, EventArgs e)
        {

        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {

        }

        private void OrderListFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            displaytest();
        }
    }
}
