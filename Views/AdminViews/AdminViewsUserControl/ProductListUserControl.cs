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
    public partial class ProductListUserControl : UserControl
    {
        private readonly ProductViewModel productViewModel = new ProductViewModel();

        public delegate void ProductListUserControlClickedEventHandler();
        public event ProductListUserControlClickedEventHandler ProductListUserControlAddProductClicked;
        public ProductListUserControl()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void ProductListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ProductListDataGridView.Rows[e.RowIndex];         
                int productId = Convert.ToInt32(selectedRow.Cells["Product_Id"].Value);

                UpdateDeleteDialogView updateDeleteDialogView = new UpdateDeleteDialogView(productId, true);
                updateDeleteDialogView.Show();
            }
        }
        private void LoadProducts()
        {
            ProductListDataGridView.DataSource = productViewModel.Products;
            CustomizeDataGridViewHeaders();
        }
        private void CustomizeDataGridViewHeaders()
        {
            if (ProductListDataGridView.Columns.Contains("Menu_Name"))
            {
                ProductListDataGridView.Columns["Menu_Name"].HeaderText = "Menu";
            }
            if (ProductListDataGridView.Columns.Contains("Product_Name"))
            {
                ProductListDataGridView.Columns["Product_Name"].HeaderText = "Product";
            }
            if (ProductListDataGridView.Columns.Contains("Product_Price"))
            {
                ProductListDataGridView.Columns["Product_Price"].HeaderText = "Price";
            }
            if (ProductListDataGridView.Columns.Contains("Product_Image_File_Path"))
            {
                ProductListDataGridView.Columns["Product_Image_File_Path"].HeaderText = "File Path";
            }
            if (ProductListDataGridView.Columns.Contains("Product_Id"))
            {
                ProductListDataGridView.Columns["Product_Id"].Visible = false;
            }
            if (ProductListDataGridView.Columns.Contains("Menu_Id"))
            {
                ProductListDataGridView.Columns["Menu_Id"].Visible = false;
            }
        }
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductListUserControlAddProductClicked?.Invoke();
        }
    }
}
