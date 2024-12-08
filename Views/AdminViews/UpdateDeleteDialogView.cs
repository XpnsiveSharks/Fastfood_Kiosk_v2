using Fastfood_Kiosk_v2.ViewModels;
using Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.AdminViews
{
    public partial class UpdateDeleteDialogView : Form
    {
        /*public delegate void UpdateDialogViewEventHandler();
        public event UpdateDialogViewEventHandler UpdateDialogViewEventHandlerNavigateToMenuList;
        public event UpdateDialogViewEventHandler UpdateDialogViewEventHandlerNavigateToProductList;

        //private InsertMenuUserControl insertMenuUserControl;
        public bool IsProductUpdate { get; set; }
        public int MenuAndProductId { get; set; }
        public UpdateDeleteDialogView()
        {
            InitializeComponent();
        } 
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (IsProductUpdate)
            {
                InsertProductUserControl insertProductUserControl = new InsertProductUserControl(MenuAndProductId);
                UpdateDialogViewClickedForMenuUpdate?.Invoke();
            }
            else
            {
                insertMenuUserControl = new InsertMenuUserControl
                {
                    MenuId = MenuAndProductId,
                };
                AdminUserControl adminUserControl = new AdminUserControl();
                adminUserControl.ChangeUserControlInAdminUserControl(insertMenuUserControl);
            }
                
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (IsProductUpdate)
            {
                
                if(DialogResultMessageBox("product"))
                {
                    ProductViewModel productViewModel = new ProductViewModel();
                    productViewModel.DeleteProduct(MenuAndProductId);
                    MessageBox.Show("Product deleted succesfully");
                    UpdateDialogViewEventHandlerNavigateToProductList?.Invoke();
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
                    UpdateDialogViewEventHandlerNavigateToMenuList?.Invoke();
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
            this.Close();
        }*/
    }
}
