using Fastfood_Kiosk_v2.Models;
using Fastfood_Kiosk_v2.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.Views.AdminViews.AdminViewsUserControl
{
    public partial class InsertProductUserControl : UserControl
    {
        public delegate void InsertProductUserControlClickedEventHandler();
        public event InsertProductUserControlClickedEventHandler InsertProductUserControlCancelClicked;
        public event InsertProductUserControlClickedEventHandler InsertProductUserControlNavigateToMenuList;
        private readonly ProductViewModel productViewModel = new ProductViewModel();
        public int ProductId { get; set; }
        private bool IsUpdate;
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
        private void IsProductUpdating()
        {
            IsUpdate = ProductId != 0;
            if (IsUpdate)
                DisplaySelectedProduct();
        }
        private void DisplaySelectedProduct()
        {
            var menu = productViewModel.GetProductById(ProductId);
            productViewModel.MenuId = menu.Menu_Id;
            productViewModel.ProductName = menu.Product_Name; 
            productViewModel.ProductPrice = menu.Product_Price;
            productViewModel.Description = menu.Description;
            productViewModel.ProductImageFilePath = menu.Product_Image_File_Path;
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
            InsertProductUserControlNavigateToMenuList?.Invoke();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            InsertProductUserControlCancelClicked?.Invoke();
        }
    }
}
