using Fastfood_Kiosk_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_v2.Repositories
{
    internal interface IProductRepository
    {
        void AddProduct(Products products);
        List<Products> GetAllProducts();
        void UpdateProduct(Products products);
        void DeleteProduct(int productId);
        Products GetProductById(int productId);
        List<Products> GetProductsWithMenuNames();
        List<Products> GetProductByMenuId(int menuId);
    }
}
