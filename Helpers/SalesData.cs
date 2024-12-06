using Dapper;
using Fastfood_Kiosk_v2.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_v2.Helpers
{
    public class SalesData
    {
        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;
        public SalesData()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
        }       

        public DateTime OrderDate {  get; set; } 
        public int OrderCount { get; set; }

        public List<SalesData> GetSalesData()
        {
            using (var connection = _databaseConnection.GetConnection())
            {
                string query = @"SELECT CAST(order_date AS DATE) AS OrderDate, Count(*) AS OrderCount
                FROM orders_table
                GROUP BY CAST(order_date AS DATE)
                ORDER BY OrderDate";

                return connection.Query<SalesData>(query).AsList();
            }

        }
    }
        
}
