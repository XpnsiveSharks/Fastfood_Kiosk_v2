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

namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    public partial class UpdateDeleteUserControl : UserControl
    {
        public event Action<int, bool> InsertMenuEventHandler;
        public bool IsProductUpdate { get; set; }
        public bool IsFromMenuListUserControl { get; set; }
        public int MenuAndProductId { get; set; }

        private InsertMenuUserControl insertMenuUserControl;
        public UpdateDeleteUserControl()
        {
            InitializeComponent();
            insertMenuUserControl = new InsertMenuUserControl();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (IsProductUpdate)
            {
                
            }
            else
            {
                var menuListUserControl = new MenuListUserControl();
                menuListUserControl.UpdateDeleteMenuListEventHandler += menuId =>
                {
                    InsertMenuEventHandler?.Invoke(menuId, true);
                };
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (IsProductUpdate)
            {

                if (DialogResultMessageBox("product"))
                {
                    ProductViewModel productViewModel = new ProductViewModel();
                    productViewModel.DeleteProduct(MenuAndProductId);
                    MessageBox.Show("Product deleted succesfully");
                }
                else
                {
                    MessageBox.Show("Product deletion canceled");
                }
            }
            else
            {
                if (DialogResultMessageBox("menu"))
                {
                    MenuViewModel menuViewModel = new MenuViewModel();
                    menuViewModel.DeleteMenu(MenuAndProductId);
                    MessageBox.Show("Menu deleted succesfully");
                }
                else
                {
                    MessageBox.Show("Menu deletion canceled");
                }
            }
        }
        private bool DialogResultMessageBox(string message)
        {
            DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete this {message}?",
                    "Deleting product",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
