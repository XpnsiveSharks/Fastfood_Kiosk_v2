using Fastfood_Kiosk_v2.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    public partial class PendingOrderListUserControl : UserControl
    {
       private readonly OrderDetailsViewModel _orderDetailsViewModel;
       private OrderDetailsUserControl _orderDetailsUserControl;

       public string OrderType { get; set; }
        public PendingOrderListUserControl(string orderType)
        {
            InitializeComponent();
            _orderDetailsViewModel = new OrderDetailsViewModel();
            OrderType = orderType;
            Console.WriteLine(OrderType);
        }

        private void PendingOrdersfLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdatePendingOrdersfLayoutPanel()
        {
            PendingOrdersfLayoutPanel.Controls.Clear();
            foreach (var control in _orderDetailsViewModel.OrderControls)
            {
            //    PendingOrdersfLayoutPanel.Controls.Add(control);
            }
        }

        public void ShowOrder(string productName, int productQuantity)
        {
            if (_orderDetailsUserControl == null)
            {
                _orderDetailsUserControl = new OrderDetailsUserControl(OrderType)
                {
                    // Dock = DockStyle.Fill,
                };
                PendingOrdersfLayoutPanel.Controls.Clear();
              //  PendingOrdersfLayoutPanel.Controls.Add(_orderDetailsUserControl);
            }
            bool orderFound = false;
            foreach (PendingOrderUserControl item in _orderDetailsUserControl.pendingOrderFlowLayout.Controls)
            {
                if (item.Product == productName)
                {
                    item.Quantity = productQuantity;
                    
                    break;
                }
            }
            if (!orderFound)
            {
                var orderControl = new PendingOrderUserControl
                {
                    Product = productName,
                    Quantity = productQuantity,
                };
                _orderDetailsUserControl.AddOrder(orderControl);
            }
               

        }
    }
}
