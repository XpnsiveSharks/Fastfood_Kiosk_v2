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
    internal class MenuRepository : IMenuRepository
    {
        private readonly DatabaseConnection _databaseConnection;
        private readonly ConfigurationLoader _configurationLoader;
        public MenuRepository()
        {
            _configurationLoader = new ConfigurationLoader();
            _databaseConnection = new DatabaseConnection(_configurationLoader.Configuration);
        }
        public void AddMenu(Menus menus)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var insertQuery = "INSERT INTO Menu_table (Menu_Name, Menu_Image_File_Path) VALUES (@Menu_Name, @Menu_Image_File_Path)";
                    connection.Execute(insertQuery, new
                    {
                        Menu_Name = menus.Menu_Name,
                        Menu_Image_File_Path = menus.Menu_Image_File_Path
                    });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        public List<Menus> GetAllMenus()
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    return connection.Query<Menus>("SELECT * FROM Menu_table").ToList();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }
        public void DeleteMenu(int menuId)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var deleteMenu = "DELETE  FROM Menu_table WHERE Menu_Id = @Menu_Id";
                    connection.Execute(deleteMenu, new { Menu_id = menuId });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        public void UpdateMenu(Menus menus)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var updateMenu = "UPDATE Menu_table SET Menu_Name = @Menu_Name, Menu_Image_File_Path = @Menu_Image_File_Path WHERE Menu_Id = @Menu_Id";
                    connection.Execute(updateMenu, new
                    {
                        Menu_Name = menus.Menu_Name,
                        Menu_Image_File_Path = menus.Menu_Image_File_Path,
                        Menu_Id = menus.Menu_Id
                    });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }

        public Menus GetMenuById(int menuId)
        {
            try
            {
                using (var connection = _databaseConnection.GetConnection())
                {
                    var query = "SELECT * FROM Menu_Table WHERE Menu_Id = @Menu_Id";
                    return connection.QuerySingleOrDefault<Menus>(query, new { Menu_Id = menuId });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error has occured while accessing the database", ex);
            }
        }
    }
}
