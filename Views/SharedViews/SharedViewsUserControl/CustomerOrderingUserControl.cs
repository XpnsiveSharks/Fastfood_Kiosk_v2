using Fastfood_Kiosk_v2.ViewModels;
using Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl;
using Fastfood_Kiosk_v2.Views.Customer.CustomerOrderingComponentsUserControls;
using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Fastfood_Kiosk_v2.Views.Customer.CustomerUserControls
{
    public partial class CustomerOrderingUserControl : UserControl
    {
        private readonly MenuViewModel _menuViewModel;
        private readonly ProductViewModel _productViewModel;
        private CartUserControl _cartUserControl;
        public string OrderType { get; set; }
        public CustomerOrderingUserControl(string orderType)
        {
            InitializeComponent();
            _menuViewModel = new MenuViewModel();
            _productViewModel = new ProductViewModel();
            InitializeMenu();
            OrderType = orderType;
            Console.WriteLine(OrderType);
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
                        var (productName, productPrice, productId) = e;
                        ShowCart(productName, productPrice, productId);
                    };
                }
                ProductsFLayoutPanel.Controls.Add(control);
            }
        }
        public void ShowCart(string productName, double productPrice, int productId)
        {
            if (_cartUserControl == null)
            {
                _cartUserControl = new CartUserControl(OrderType)
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
                    Total = productPrice,
                    ProductId = productId
                };

                _cartUserControl.AddItem(itemControl); 
            }
            _cartUserControl.UpdateSubtotal(); 
        }

        private void ProductsFLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
