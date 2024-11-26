using Fastfood_Kiosk_v2.ViewModels;
using Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl;
using System;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls
{
    public partial class CustomerOrderingUserControl : UserControl
    {
        private readonly MenuViewModel _menuViewModel;
        private readonly ProductViewModel _productViewModel;

        public CustomerOrderingUserControl()
        {
            InitializeComponent();
            _menuViewModel = new MenuViewModel();
            _productViewModel = new ProductViewModel();
            InitializeMenu();
        }
        private void InitializeMenu()
        {
            _menuViewModel.LoadMenuToCashierUserControl();
            UpdateMenuPanel();
        }
        private void UpdateMenuPanel()
        {
            MenuFlowLayoutPanel.Controls.Clear();

            foreach (var control in _menuViewModel.MenuCashierControls)
            {
                if (control is MenuForCashierUserControl menuControl)
                {
                    menuControl.MenuForCashierUserControlClicked += OnMenuClicked;
                }
                MenuFlowLayoutPanel.Controls.Add(control);
            }
        }
        private void OnMenuClicked(int menuId)
        {
            ReloadProducts(menuId);
        }
        private void ReloadProducts(int menuId)
        {
            _productViewModel.LoadProductsToUserControl(menuId);
            UpdateProductPanel();
        }
        private void UpdateProductPanel()
        {
            ProductsFLayoutPanel.Controls.Clear();

            foreach (var control in _productViewModel.ProductControls)
            {
                if (control is ProductButtonsUserControl productControl)
                {
                    productControl.ProductClicked += (s, e) => ShowCart();
                }
                ProductsFLayoutPanel.Controls.Add(control);
            }
        }
        public void ShowCart()
        {
            var cartUserControl = new CartUserControl
            {
                Dock = DockStyle.Fill
            };

            CartPanel.Controls.Clear();
            CartPanel.Controls.Add(cartUserControl);
        }
    }
}
