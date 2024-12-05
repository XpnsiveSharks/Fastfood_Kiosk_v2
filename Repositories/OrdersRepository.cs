﻿using Dapper;
using Fastfood_Kiosk_v2.Configurations;
using Fastfood_Kiosk_v2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;

namespace Fastfood_Kiosk_v2.Repositories
{
    internal class OrdersRepository : IOrdersRepository
    {
        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;
        public OrdersRepository()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
        }
        public void AddOrders(Orders orders)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var insertQuery = "INSERT INTO Orders_table (Order_Number, Order_Date, Order_Type, Customer_Id, Total_Amount, Status, Payment_Method) VALUES (@Order_Number, @Order_Date, @Order_Type, @Customer_Id, @Total_Amount, @Status, @Payment_Method)";
                    connection.Execute(insertQuery, new
                    {
                        Order_Number = orders.Order_Number,
                        Order_Date = orders.Order_Date,
                        Order_Type = orders.Order_Type,
                        Customer_Id = orders.Customer_Id,
                        Total_Amount = orders.Total_Amount,
                        Status = orders.Status,
                        Payment_Method = orders.Payment_Method
                    });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        public int GetOrderIdByOrderNumber(string orderNumber)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var query = "SELECT Order_Id FROM orders_table WHERE Order_Number = @Order_Number";
                    return connection.QuerySingleOrDefault<int>(query, new { Order_Number = orderNumber });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        public string GetOrderNumber()
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var query = "SELECT Order_Number FROM orders_table WHERE Order_Id = (SELECT MAX(Order_Id) FROM orders_table)";
                    string ordernumber = connection.QuerySingleOrDefault<string>(query);
                    return ordernumber ?? "B00000";
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }
    }
}
