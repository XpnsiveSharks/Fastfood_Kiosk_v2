﻿using Dapper;
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
            PasswordHashing passwordHashing = new PasswordHashing();
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var selectQuery = "SELECT Password FROM users_table WHERE Username = @username AND User_Role = @userRole";
                    string storedPasswordHash = connection.QuerySingleOrDefault<string>(selectQuery, new
                    {
                        username = username,
                        userRole = userRole
                    });

                    if (string.IsNullOrEmpty(storedPasswordHash))
                    {
                        return false; // User not found or role mismatch
                    }

                    string enteredPasswordHash = passwordHashing.hashPassword(password);
                    return storedPasswordHash == enteredPasswordHash;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while accessing the database: {ex.Message}");
                return false;
            }
        }

    }
}

