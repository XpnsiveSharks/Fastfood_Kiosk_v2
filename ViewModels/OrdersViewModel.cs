using Dapper;
using Fastfood_Kiosk_v2.Configurations;
using Fastfood_Kiosk_v2.Models;
using Fastfood_Kiosk_v2.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_v2.ViewModels
{
    internal class OrdersViewModel : INotifyPropertyChanged
    {
        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;
        private readonly OrdersRepository ordersRepository;

        public OrdersViewModel()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
            LoadOrders();
        }

        private List<Orders> _orders;

        public List<Orders> Order
        {
            get => _orders;
            set
            {
                _orders = value;
                OnPropertyChanged(nameof(Order));
            }
        }

        public List<OrderDetails> LoadOrders(string startDate = null, string endDate = null)
        {
            using (var connection = _databaseConnection.GetConnection())
            {
                string query = @"
            SELECT 
                o.Order_Number AS OrderNumber,
                DATE_FORMAT(o.Order_Date, '%Y-%m-%d %H:%i:%s') AS OrderDate,
                o.Order_Type AS OrderType,
                o.Total_Amount AS TotalAmount,
                p.Product_Name AS ProductName,
                oi.Quantity AS Quantity
            FROM Orders_Table o
            INNER JOIN Order_Items_Table oi ON o.Order_Id = oi.Order_Id
            INNER JOIN Products_Table p ON oi.Product_Id = p.Product_Id
            WHERE (@StartDate IS NULL OR o.Order_Date >= @StartDate)
              AND (@EndDate IS NULL OR o.Order_Date <= @EndDate)
            ORDER BY o.Order_Date DESC;
        ";

                return connection.Query<OrderDetails>(query, new { StartDate = startDate, EndDate = endDate }).ToList();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
