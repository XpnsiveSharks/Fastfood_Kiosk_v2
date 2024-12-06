using System;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls
{
    public partial class OrderTypeUserControl : UserControl
    {

        public event Action<string> OrderTypeChanged;
        public OrderTypeUserControl()
        {
            InitializeComponent();
        }
        private void DineInButton_Click(object sender, EventArgs e)
        {
            OrderTypeChanged?.Invoke("Dine In");
        }

        private void TakeOutButton_Click(object sender, EventArgs e)
        {
            OrderTypeChanged?.Invoke("Take Out");
        }
    }
}
