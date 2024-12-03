using Dapper;
using Fastfood_Kiosk_v2.Configurations;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_v2.Helpers
{
    internal class PasswordHashing
    {
        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;


        public PasswordHashing()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
        }

        public string hashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder stringBuilder = new StringBuilder();  

                foreach (byte b in bytes)
                {
                    stringBuilder.Append(b.ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }

        public void SaveToDatabase(string username, string passwordHash)
        {

            using (var connection = _databaseConnection.GetConnection())
            {
                string query = "INSERT INTO users_table (Username, Password) VALUES (@username, @password)";
                connection.Execute(query, new
                {
                    @username = username,
                    @password = passwordHash
                });
            }
        }            
    }
}
