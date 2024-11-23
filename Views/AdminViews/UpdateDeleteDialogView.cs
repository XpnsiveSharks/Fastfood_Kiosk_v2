using Fastfood_Kiosk_v2.ViewModels;
using Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl;
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
        public delegate void UpdateDialogViewClickedEventHandler();
        public event UpdateDialogViewClickedEventHandler UpdateDialogViewClickedForProductUpdate;
        public event UpdateDialogViewClickedEventHandler UpdateDialogViewClickedForMenuUpdate;

        private readonly AdminUserControl adminUserControl = new AdminUserControl();

        private bool IsProductUpdate;
        public int MenuAndProductId { get; set; }
        public UpdateDeleteDialogView(int MenuAndProductId, bool IsProductUpdate)
        {
            InitializeComponent();
            this.MenuAndProductId = MenuAndProductId;
            this.IsProductUpdate = IsProductUpdate;
        } 
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (IsProductUpdate)
            {
                //InsertProductUserControl insertProductUserControl = new InsertProductUserControl(MenuAndProductId);
                UpdateDialogViewClickedForProductUpdate?.Invoke();
            }
            else
            {
                InsertMenuUserControl insertMenuUserControl = new InsertMenuUserControl(MenuAndProductId);
                UpdateDialogViewClickedForMenuUpdate?.Invoke();
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
                    //show product list user control
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
                    //show menu list user control
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
        }
    }
}
