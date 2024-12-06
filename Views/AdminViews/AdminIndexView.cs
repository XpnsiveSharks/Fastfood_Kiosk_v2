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

    public partial class AdminIndexView : Form
    {
        private MenuListUserControl menuListUserControl;
        private UpdateDeleteUserControl updateDeleteUserControl;
        private ProductListUserControl productListUserControl;
        public AdminIndexView()
        {
            InitializeComponent();
            menuListUserControl = new MenuListUserControl();
            updateDeleteUserControl = new UpdateDeleteUserControl();
            productListUserControl = new ProductListUserControl();
            menuListUserControl.AddMenuEventHandler += OnAddMenu;
            menuListUserControl.UpdateDeleteMenuListEventHandler += OnUpdateDeleteMenu;
            productListUserControl.UpdateDeleteProductListEventHandler += OnUpdateDeleteProduct;
            updateDeleteUserControl.UpdateMenuEventHandler += OnUpdateMenu;
            updateDeleteUserControl.UpdateProductEventHandler += OnUpdateProduct;

            productListUserControl.AddProductEventHandler += OnAddProduct;
    }


        private void DashboardButton_Click(object sender, EventArgs e)
        {
            
        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            LoadUserControl(menuListUserControl);
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            LoadUserControl(productListUserControl);
        }

        private void StaffButton_Click(object sender, EventArgs e)
        {

        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {

        }
        private void OnReloadMenu()
        {
            menuListUserControl.ReloadMenus();
            LoadUserControl(menuListUserControl);
        }
        private void OnReloadProducts()
        {
            productListUserControl.ReloadProducts();
            LoadUserControl(productListUserControl);
        }
        private void OnAddMenu()
        {
            var insertMenuUserControl = new InsertMenuUserControl();
            insertMenuUserControl.BackToMenuListEventHandler += OnReloadMenu;
            updateDeleteUserControl.BackToMenuListEventHandler += OnReloadMenu;
            LoadUserControl(insertMenuUserControl);
        }
        private void OnAddProduct()
        {
            var insertProductUserControl = new InsertProductUserControl();
            insertProductUserControl.BackToProductListEventHandler += OnReloadProducts;
            updateDeleteUserControl.BackToProductListEventHandler += OnReloadProducts;
            LoadUserControl(insertProductUserControl);
        }
        private void OnUpdateMenu(int menuId)
        {
            var insertMenuUserControl = new InsertMenuUserControl
            {
                MenuId = menuId,
                IsUpdate = true
            };

            insertMenuUserControl.InitializeControl(); 

            insertMenuUserControl.BackToMenuListEventHandler += OnReloadMenu;

            LoadUserControl(insertMenuUserControl);
        }
        private void OnUpdateProduct(int productId)
        {
            var insertProductUserControl = new InsertProductUserControl
            {
                ProductId = productId,
                IsUpdate = true 
            };

            insertProductUserControl.InitializeControl();
            insertProductUserControl.BackToProductListEventHandler += OnReloadProducts;
            LoadUserControl(insertProductUserControl);
        }

        private void OnUpdateDeleteMenu(int menuId, bool isProductUpdate, bool isFromMenuListUserControl)
        {
            var updateDeleteUserControl = new UpdateDeleteUserControl
            {
                MenuAndProductId = menuId,
                IsProductUpdate = isProductUpdate, 
                IsFromMenuListUserControl = isFromMenuListUserControl
            };

            updateDeleteUserControl.UpdateMenuEventHandler += OnUpdateMenu;
            updateDeleteUserControl.BackToMenuListEventHandler += OnReloadMenu;

            LoadUserControl(updateDeleteUserControl);
        }
        private void OnUpdateDeleteProduct(int productId, bool isProduct, bool isFromMenuList)
        {
            var updateDeleteUserControl = new UpdateDeleteUserControl
            {
                MenuAndProductId = productId,
                IsProductUpdate = isProduct,
                IsFromMenuListUserControl = isFromMenuList
            };

            updateDeleteUserControl.UpdateProductEventHandler += OnUpdateProduct;
            updateDeleteUserControl.BackToProductListEventHandler += OnReloadProducts; 

            LoadUserControl(updateDeleteUserControl);
        }



        private void LoadUserControl(UserControl userControl)
        {
            AdminIndexPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            AdminIndexPanel.Controls.Add(userControl);
        }
    }
}
