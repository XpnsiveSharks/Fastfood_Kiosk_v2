using Dapper;
using Fastfood_Kiosk_v2.Configurations;
using Fastfood_Kiosk_v2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_v2.Repositories
{
    internal class ProductRepository : IProductRepository
    {
        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;
        public ProductRepository()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
        }
        public void AddProduct(Products products)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var insertQuery = "INSERT INTO products_table (Menu_Id, Product_Name, Product_Price, Description, Product_Image_File_Path) VALUES (@Menu_Id, @Product_Name, @Product_Price, @Description, @Product_Image_File_Path)";
                    connection.Execute(insertQuery, new
                    {
                        Menu_Id = products.Menu_Id,
                        Product_Name = products.Product_Name,
                        Product_Price = products.Product_Price,
                        Description = products.Description,
                        Product_Image_File_Path = products.Product_Image_File_Path
                    });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }
        public void DeleteProduct(int productId)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var deleteProduct = "DELETE  FROM Products_table WHERE Product_Id = @Product_Id";
                    connection.Execute(deleteProduct, new { Product_Id = productId });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }
        public List<Products> GetAllProducts()
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    return connection.Query<Products>("SELECT * FROM Products_table").ToList();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }
        public List<Products> GetProductsWithMenuNames()
        {
            using (var connection = _databaseConnection.GetConnection())
            {
                var query = @" SELECT p.Product_Id, m.Menu_Name, p.Product_Name, p.Product_Price, p.Description, p.Product_Image_File_Path FROM PRODUCTS_TABLE p INNER JOIN MENU_TABLE m ON p.Menu_Id = m.Menu_Id";
                return connection.Query<Products>(query).ToList();
            }
        }
        public Products GetProductById(int productId)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var query = "SELECT * FROM Products_Table WHERE Product_Id = @Product_Id";
                    return connection.QuerySingleOrDefault<Products>(query, new { Product_Id = productId });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }
        public List<Products> GetProductByMenuId(int menuId)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var query = "SELECT * FROM Products_Table WHERE Menu_Id = @Menu_Id";
                    return connection.Query<Products>(query, new { Menu_Id = menuId }).ToList();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occurred while accessing the database.", ex);
            }
        }
        public void UpdateProduct(Products products)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var updateCategory = "UPDATE Products_Table SET Menu_Id = @Menu_Id, Product_Name = @Product_Name, Product_Price = @Product_Price, Description = @Description, Product_Image_File_Path = @Product_Image_File_Path WHERE Product_Id = @Product_Id";
                    connection.Execute(updateCategory, new
                    {
                        Product_Id = products.Product_Id,
                        Menu_Id = products.Menu_Id,
                        Product_Name = products.Product_Name,
                        Product_Price = products.Product_Price,
                        Description = products.Description,
                        Product_Image_File_Path = products.Product_Image_File_Path
                    });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }
    }
}
