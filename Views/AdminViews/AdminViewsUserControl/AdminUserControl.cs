using System;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    public partial class AdminUserControl : UserControl
    {
        public delegate void AdminUserControlClickedEventHandler();
        public event AdminUserControlClickedEventHandler MenuListAdminUserControlClicked;
        public event AdminUserControlClickedEventHandler ProductListAdminUserControlClicked;

        private readonly MenuListUserControl menuListUserControl = new MenuListUserControl();
        private readonly InsertMenuUserControl insertMenuUserControl = new InsertMenuUserControl();
        private readonly ProductListUserControl productListUserControl = new ProductListUserControl();
        private readonly InsertProductUserControl insertProductUserControl = new InsertProductUserControl();
        private readonly UpdateDeleteUserControl updateDeleteUserControl = new UpdateDeleteUserControl();
        public AdminUserControl()
        {
            InitializeComponent();
            InitializeEventHandlers();
            DisplayListMenuUserControl();
        }

        private void InitializeEventHandlers()
        {
            menuListUserControl.MenuListUserControlAddMenuClicked += OnMenuListUserControlAddMenuClicked;
            insertMenuUserControl.InsertMenuUserControlClicked += DisplayListMenuUserControl;
            productListUserControl.ProductListUserControlAddProductClicked += OnProductListUserControlAddProductClicked;
            insertProductUserControl.InsertProductUserControlCancelClicked += DisplayProductListUserControl;
            productListUserControl.ProductListUserControlNavigateToUpdateDeleteUserControl += DisplayUpdateDeleteUserControl;
            menuListUserControl.MenuListUserControlAddMenuNavigateToUpdateDeleteUserControl += DisplayUpdateDeleteUserControl;
            updateDeleteUserControl.UpdateDialogViewEventHandlerNavigateToMenuList += DisplayListMenuUserControl;
            updateDeleteUserControl.UpdateDialogViewEventHandlerNavigateToProductList += DisplayProductListUserControl;
            insertMenuUserControl.InsertMenuUserControlGoToMenuListClicked += () =>
            {
                ChangeUserControl(menuListUserControl);
                menuListUserControl.ReloadMenus();
            };
            insertProductUserControl.InsertProductUserControlNavigateToMenuList += () =>
            {
                ChangeUserControl(productListUserControl);
                productListUserControl.ReloadProducts();
            };
        }

        private void MenuListButton_Click(object sender, EventArgs e)
        {
            ChangeUserControl(menuListUserControl);
        }

        private void ProductListButton_Click(object sender, EventArgs e)
        {
            ChangeUserControl(productListUserControl);
        }
        public void DisplayUpdateDeleteUserControl()
        {
            ChangeUserControl(updateDeleteUserControl);
        }

        public void DisplayListMenuUserControl()
        {
            ChangeUserControl(menuListUserControl);
        }

        private void OnMenuListUserControlAddMenuClicked()
        {
            ChangeUserControl(insertMenuUserControl);
        }

        private void OnProductListUserControlAddProductClicked()
        {
            ChangeUserControl(insertProductUserControl);
        }

        private void DisplayProductListUserControl()
        {
            ChangeUserControl(productListUserControl);
        }

        private void ChangeUserControl(UserControl userControl)
        {
            AdminFlowLayoutPanel.Controls.Clear();
            AdminFlowLayoutPanel.Controls.Add(userControl);
        }
    }
}
