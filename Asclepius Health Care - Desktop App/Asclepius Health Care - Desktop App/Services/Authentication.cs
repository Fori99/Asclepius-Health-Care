using Asclepius_Health_Care___Desktop_App.Models;
using Asclepius_Health_Care___Desktop_App.SQL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asclepius_Health_Care___Desktop_App.SessionData;

namespace Asclepius_Health_Care___Desktop_App.Services
{
    internal class Authentication
    {
        public string Login(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(Connection_String.ConnectionString))
            {
                connection.Open();

                // Prepare the SQL query
                string query = "SELECT * FROM users WHERE username = @username AND pass = @password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password); // Assuming password is in plain text


                // Execute the query
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        SessionDatas.FullName = reader[1].ToString();
                        MessageBox.Show("Welcome Back " + SessionDatas.FullName + "!");
                        
                        return reader[2].ToString();                        
                    }
                    else
                    {                        
                        return null;
                    }
                }
            }
        }
    }
}
