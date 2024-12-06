using Dapper;
using Fastfood_Kiosk_v2.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_v2.Helpers
{
    internal class ValidateCredentials
    {
        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;
        public ValidateCredentials()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
        }

        public bool validateCredentials(string username, string password, string userRole)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    string query = "SELECT COUNT(1) from users_table WHERE user_role = @userRole AND Username = @username AND Password = @password";
                    int count = connection.ExecuteScalar<int>(query, new
                    {
                        @username = username,
                        @password = password,
                        @userRole = userRole
                    });
                    return count == 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error has occurred while accessing the database", ex);
            }
        }

    }
}

