using Fastfood_Kiosk_v2.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Fastfood_Kiosk_v2.Models;
using System.Data.SqlClient;

namespace Fastfood_Kiosk_v2.Repositories
{
    internal class AdminRepository : IAdminRepository
    {

        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;
        public AdminRepository()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
        }
        public bool UpdateAdmin(string currentPassword, string newPassword)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var updateQuery = "UPDATE users_table SET Password = @NewPassword WHERE Password = @CurrentPassword";

                    int rowsAffected = connection.Execute(updateQuery, new
                    {
                        @CurrentPassword = currentPassword,
                        @NewPassword = newPassword
                    });

                    return rowsAffected > 0; 
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while accessing the database", ex);
            }
        }



    }
}
