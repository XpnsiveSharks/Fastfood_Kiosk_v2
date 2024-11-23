using Fastfood_Kiosk_v2.Models;
using Fastfood_Kiosk_v2.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_v2.ViewModels
{
    internal class ProductViewModel : INotifyPropertyChanged
    {
        private readonly ProductRepository _productRepository;
        public event PropertyChangedEventHandler PropertyChanged;
        public ProductViewModel()
        {
            _productRepository = new ProductRepository();
            LoadMenus();
            //LoadProductsToUserControl();
        }
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private List<Products> _products;
        public List<Products> Products
        {
            get => _products;
            set
            {
                if (_products != value)
                {
                    _products = value;
                    OnPropertyChanged(nameof(Products));
                }
            }
        }
        private int _menuId;
        public int MenuId
        {
            get => _menuId;
            set
            {
                _menuId = value;
                OnPropertyChanged(nameof(MenuId));
            }
        }
        private string _productName;
        public string ProductName
        {
            get => _productName;
            set
            {
                _productName = value;
                OnPropertyChanged(nameof(ProductName));
            }
        }
        private double _productPrice;
        public double ProductPrice
        {
            get => _productPrice;
            set
            {
                _productPrice = value;
                OnPropertyChanged(nameof(ProductPrice));
            }
        }
        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
        private string _productImageFilePath;
        public string ProductImageFilePath
        {
            get => _productImageFilePath;
            set
            {
                _productImageFilePath = value;
                OnPropertyChanged(nameof(ProductImageFilePath));
                OnPropertyChanged(nameof(SelectedProductImage));
            }
        }
        public Image SelectedProductImage =>
             !string.IsNullOrEmpty(_productImageFilePath) ? Image.FromFile(_productImageFilePath) : null;
        /// <summary>
        /// Adding menu
        /// </summary>
        public void AddingMenu()
        {
            var newProduct = new Products
            {
                Menu_Id = _menuId,
                Product_Name = _productName,
                Product_Price = _productPrice,
                Description = _description,
                Product_Image_File_Path = _productImageFilePath
            };
            _productRepository.AddProduct(newProduct);
        }
        /// <summary>
        /// Loading menus
        /// </summary>
        public void LoadMenus()
        {
            Products = _productRepository.GetProductsWithMenuNames();
        }
        /// <summary>
        /// Updating menu
        /// </summary>
        /// <param name="menuId"></param>
        public void UpdateProduct(int product)
        {
            var updatedProduct = new Products
            {
                Product_Id = product,
                Menu_Id = this._menuId,
                Product_Name = this._productName,
                Product_Price = this._productPrice,
                Description = this._description,
                Product_Image_File_Path = this._productImageFilePath
            };
            _productRepository.UpdateProduct(updatedProduct);
        }
        /// <summary>
        /// Getting the MenuItem using Id
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        public Products GetProductById(int productId)
        {
            return _productRepository.GetProductById(productId);
        }
        public void DeleteProduct(int productId)
        {
            _productRepository.DeleteProduct(productId);
        }

       /* private List<ProductButtonsUserControl> _productControls;
        public List<ProductButtonsUserControl> ProductControls
        {
            get => _productControls;
            set
            {
                if (_productControls != value)
                {
                    _productControls = value;
                    OnPropertyChanged(nameof(ProductControls));
                }
            }
        }
        public void LoadProductsToUserControl(int menuId)
        {
            List<ProductButtonsUserControl> productDisplayUserControls = new List<ProductButtonsUserControl>();
            foreach (var item in _productRepository.GetProductByMenuId(menuId))
            {
                ProductButtonsUserControl productDisplayUserControl = new ProductButtonsUserControl
                {
                    ProductNames = item.Product_Name,
                    ProductPrice = item.Product_Price
                };
                string imagePath = Path.Combine(Application.StartupPath, "Resources", item.Product_Image_File_Path);
                string fallbackImagePath = Path.Combine(Application.StartupPath, "Resources", "D:\\Repositories\\bin\\Debug\\no_image.jpg");
                productDisplayUserControl.ProductImage = File.Exists(imagePath)
                    ? Image.FromFile(imagePath)
                    : Image.FromFile(fallbackImagePath);
                productDisplayUserControls.Add(productDisplayUserControl);
            }
            ProductControls = productDisplayUserControls;
        }*/
    }
}
