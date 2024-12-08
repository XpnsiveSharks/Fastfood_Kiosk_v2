using Fastfood_Kiosk_v2.Models;
using Fastfood_Kiosk_v2.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    public partial class InsertProductUserControl : UserControl
    {

        private readonly ProductViewModel productViewModel = new ProductViewModel();
        public event Action BackToProductListEventHandler;

        public int ProductId { get; set; }
        public bool IsUpdate;
        public InsertProductUserControl()
        {
            InitializeComponent();
            InitializeDataBindings();
            IsProductUpdating();
            LoadMenuInComboBox();
        }
        private void InitializeDataBindings()
        {
            ProductPreviewPictureBox.DataBindings.Add("Image", productViewModel, nameof(productViewModel.SelectedProductImage), true, DataSourceUpdateMode.OnPropertyChanged);
            ProductNameTextBox.DataBindings.Add("Text", productViewModel, nameof(productViewModel.ProductName), true, DataSourceUpdateMode.OnPropertyChanged);
            ProductPriceTextBox.DataBindings.Add("Text", productViewModel, nameof(productViewModel.ProductPrice), true, DataSourceUpdateMode.OnPropertyChanged);
            ProductDescriptionTextBox.DataBindings.Add("Text", productViewModel, nameof(productViewModel.Description), true, DataSourceUpdateMode.OnPropertyChanged);
        }
        public void InitializeControl()
        {
            if (IsUpdate)
            {
                DisplaySelectedProduct();
            }
            else
            {
                ResetForm();
            }
        }
        private void ResetForm()
        {
            productViewModel.ProductName = string.Empty;
            productViewModel.ProductPrice = 0;
            productViewModel.Description = string.Empty;
            productViewModel.ProductImageFilePath = string.Empty;
            productViewModel.MenuId = 0;
        }

        private void IsProductUpdating()
        {
            IsUpdate = ProductId != 0;
            if (IsUpdate)
                DisplaySelectedProduct();
        }
        private void DisplaySelectedProduct()
        {
            var product = productViewModel.GetProductById(ProductId);
            if (product == null)
            {
                MessageBox.Show("Product not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BackToProductListEventHandler?.Invoke();
                return;
            }

            productViewModel.MenuId = product.Menu_Id;
            productViewModel.ProductName = product.Product_Name;
            productViewModel.ProductPrice = product.Product_Price;
            productViewModel.Description = product.Description;
            productViewModel.ProductImageFilePath = product.Product_Image_File_Path;
        }

        private void LoadMenuInComboBox()
        {
            var menuViewModel = new MenuViewModel();
            var categories = menuViewModel.Menus;

            ProductMenuComboBox.DataSource = categories;
            ProductMenuComboBox.DisplayMember = "Menu_Name";
            ProductMenuComboBox.ValueMember = "Menu_Id";
            ProductMenuComboBox.DataBindings.Add("SelectedValue", productViewModel, nameof(productViewModel.MenuId), true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void ProductImageUploadButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    productViewModel.ProductImageFilePath = openFileDialog.FileName;
                    MessageBox.Show("File Selected!");
                }
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productViewModel.ProductName))
            {
                MessageBox.Show("Please enter product name.");
                return;
            }
            if (string.IsNullOrEmpty(productViewModel.ProductImageFilePath))
            {
                MessageBox.Show("Please upload an Image.");
                return;
            }
            if (IsUpdate)
            {
                productViewModel.UpdateProduct(ProductId);
                MessageBox.Show("Product updated successfully");
            }
            else
            {
                productViewModel.AddingMenu();
                MessageBox.Show("Product saved successfully");
            }
            BackToProductListEventHandler?.Invoke();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            BackToProductListEventHandler?.Invoke();
        }
    }
}
