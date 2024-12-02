using Fastfood_Kiosk_v2.ViewModels;
using Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl;
using Fastfood_Kiosk_v2.Views.Customer.CustomerOrderingComponentsUserControls;
using System;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls
{
    public partial class CustomerOrderingUserControl : UserControl
    {
        private readonly MenuViewModel _menuViewModel;
        private readonly ProductViewModel _productViewModel;
        private CartUserControl _cartUserControl;
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
                    productControl.ProductClicked += (s, e) =>
                    {
                        var (productName, productPrice) = e;
                        ShowCart(productName, productPrice);
                    };
                }
                ProductsFLayoutPanel.Controls.Add(control);
            }
        }
        public void ShowCart(string productName, double productPrice)
        {
            if (_cartUserControl == null)
            {
                _cartUserControl = new CartUserControl
                {
                    Dock = DockStyle.Fill
                };
                CartPanel.Controls.Clear();
                CartPanel.Controls.Add(_cartUserControl);
            }

            bool itemFound = false;

            foreach (ItemUserControl item in _cartUserControl.itemsFlowLayoutPanel.Controls)
            {
                if (item.Product == productName)
                {
                    item.Quantity += 1;
                    item.Total = item.Price * item.Quantity;
                    itemFound = true;
                    break;
                }
            }

            if (!itemFound)
            {
                var itemControl = new ItemUserControl
                {
                    Product = productName,
                    Price = productPrice,
                    Quantity = 1,
                    Total = productPrice
                };

                _cartUserControl.AddItem(itemControl); 
            }
            _cartUserControl.UpdateSubtotal(); 
        }
      


    }
}
