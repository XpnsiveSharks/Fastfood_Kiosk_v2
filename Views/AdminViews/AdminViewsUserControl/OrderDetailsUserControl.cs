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
    public partial class OrderDetailsUserControl : UserControl
    {
        public OrderDetailsUserControl(string orderType)
        {
            InitializeComponent();
        }

        public FlowLayoutPanel pendingOrderFlowLayout
        {
            get { return this.PendingOrderFlowLayout; }
        }

        public string Order_Number
        {
            get => OrderNumber.Text;
            set => OrderNumber.Text = value;
        }

        public string Order_Date
        {
            get => OrderDate.Text;
            set => OrderDate.Text = value;
        }

        public string Order_Type
        {
            get => OrderType.Text;
            set => OrderType.Text = value;
        }

        public void AddOrder(PendingOrderUserControl orderControl)
        {
            if (orderControl == null) throw new ArgumentNullException(nameof(orderControl));
            PendingOrderFlowLayout.Controls.Add(orderControl);
        }

        private void PendingOrderFlowLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
