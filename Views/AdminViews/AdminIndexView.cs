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
        private ReportsUserControl reportsUserControl;
        private SettingsUserControl settingsUserControl;
        private CreateAccountUserControl createAccountUserControl;
        private UpdateAccountUserControl updateAccountUserControl;
        private DeleteAccountUserControl deleteAccountUserControl;
        public AdminIndexView()
        {
            InitializeComponent();
            reportsUserControl = new ReportsUserControl();
            menuListUserControl = new MenuListUserControl();
            updateDeleteUserControl = new UpdateDeleteUserControl();
            productListUserControl = new ProductListUserControl();
            settingsUserControl = new SettingsUserControl();
            createAccountUserControl = new CreateAccountUserControl();
            updateAccountUserControl = new UpdateAccountUserControl();
            deleteAccountUserControl = new DeleteAccountUserControl();
            menuListUserControl.AddMenuEventHandler += OnAddMenu;
            menuListUserControl.UpdateDeleteMenuListEventHandler += OnUpdateDeleteMenu;
            productListUserControl.UpdateDeleteProductListEventHandler += OnUpdateDeleteProduct;
            updateDeleteUserControl.UpdateMenuEventHandler += OnUpdateMenu;
            updateDeleteUserControl.UpdateProductEventHandler += OnUpdateProduct;
            createAccountUserControl.BackSettingsUserControltEventHandler += OnReloadSettings;
            productListUserControl.AddProductEventHandler += OnAddProduct;
            settingsUserControl.CreateAccountEventHandler += OnCreateAccount;
            updateAccountUserControl.BackSettingsUserControltEventHandler += OnReloadSettings;
            settingsUserControl.UpdateAccountEventHandler += OnUpdateAccount;
            settingsUserControl.DeleteAccountEventHandler += OnDeleteAccount;
            deleteAccountUserControl.BackSettingsUserControltEventHandler += OnReloadSettings;
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            LoadUserControl(reportsUserControl);
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            LoadUserControl(menuListUserControl);

        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            LoadUserControl(productListUserControl);

        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {

        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            //LoadUserControl(reportsUserControl);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            LoadUserControl(settingsUserControl);
            settingsUserControl.UpdateLoggedInUser();
        }
        private void OnUpdateAccount()
        {
            LoadUserControl(updateAccountUserControl);
        }
        private void OnDeleteAccount()
        {
            LoadUserControl(deleteAccountUserControl);
        }
        private void OnCreateAccount()
        {
            
            LoadUserControl(createAccountUserControl);
        }
        private void OnReloadSettings()
        {
            LoadUserControl(settingsUserControl);
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

        private void AdminIndexPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
