using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows;
using WelcomeToTheClub.Models;

namespace WelcomeToTheClub.Controllers
{
    // В этом классе находится логика работы с базой данных
    public class DataBaseController
    {
        private static MySqlConnection Connection;
        public static void Connect()
        {
            var connectionString = "server=localhost;database=test;user id=root;password=1234;";

            Connection = new MySqlConnection(connectionString);
            Connection.Open();
        }

        public static List<UserModel> SelectUsers()
        {
            List<UserModel> users = new List<UserModel>();
            MySqlCommand command = Connection.CreateCommand();
            command.CommandText = "SELECT * FROM users;";
            var result = command.ExecuteReader();

            while (result.Read())
            {
                users.Add(new UserModel() { Login = result.GetString(0), ID = result.GetInt32(1), Company = result.GetString(2), Password = result.GetString(3), Role = result.GetInt32(4) });
            }
            return users;
        }
    }
}
