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
    public partial class PendingOrderUserControl : UserControl
    {
        public PendingOrderUserControl()
        {
            InitializeComponent();
        }

      public string Product
        {
            get => NamePendingOrder.Text;
            set => NamePendingOrder.Text = value;
        }
      
      public int Quantity
        {
            get => int.TryParse(QuantityPendingOrder.Text, out var quantity) ? quantity : 0;
            set => QuantityPendingOrder.Text = value.ToString();
        }

      public void LoadOrderDetails()
        {

        }
    }
}
