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
    public partial class CashierUserControl : UserControl
    {
        private readonly MenuViewModel menuViewModel = new MenuViewModel();
        private readonly ProductViewModel productViewModel = new ProductViewModel();
        public CashierUserControl()
        {
            InitializeComponent();
            InitializeMenuUserControl();
        }
        private void InitializeMenuUserControl()
        {
            menuViewModel.LoadMenuToCashierUserControl();
            UpdateMenuFlowLayoutPanel();
        }
        public void ReloadProducts(int menuId)
        {
            productViewModel.LoadProductsToUserControl(menuId);
            UpdateProductFlowLayoutPanel();
        }
        private void OnMenuCashierUserControlClicked(int menuId)
        {
            ReloadProducts(menuId);
        }
        private void UpdateMenuFlowLayoutPanel()
        {
            MenuFlowLayoutPanel.Controls.Clear();
            foreach (var control in menuViewModel.MenuCashierControls)
            {
                if (control is MenuForCashierUserControl menuForCashierUserControl)
                {
                    menuForCashierUserControl.MenuForCashierUserControlClicked += OnMenuCashierUserControlClicked;
                }
                MenuFlowLayoutPanel.Controls.Add(control);
            }
        }
        private void UpdateProductFlowLayoutPanel()
        {
            ProductsFlowLayoutPanel.Controls.Clear();
            foreach (var control in productViewModel.ProductControls)
            {
                ProductsFlowLayoutPanel.Controls.Add(control);
            }
        }

    }
}
