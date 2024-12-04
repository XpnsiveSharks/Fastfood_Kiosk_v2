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
    internal class OrderItemsRepository : IOrderItemsRepository
    {
        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;
        public OrderItemsRepository()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
        }
        public void AddOrderItems(OrderItems orderItems)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var insertQuery = "INSERT INTO Order_Items_Table (Order_Id, Product_Id, Quantity, Price) VALUES (@Order_Id, @Product_Id, @Quantity, @Price)";
                    connection.Execute(insertQuery, new
                    {
                        Order_Id = orderItems.Order_Id,
                        Product_Id = orderItems.Product_Id,
                        Quantity = orderItems.Quantity,
                        Price = orderItems.Price
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
