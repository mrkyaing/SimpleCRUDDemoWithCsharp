using System;
using System.Data.SqlClient;
namespace SimpleCRUDDemo{
    public class DatabaseConnection{
        public static SqlConnection GetSqlConnection() {
            SqlConnection connection = null;
            try {
                string ConnectionString = "Data Source=localhost;Initial Catalog=SimpleDB;User Id=sa;Password=sasa";
                 connection = new SqlConnection(ConnectionString);//create the sqlConnection Object
                connection.Open();//open database connection               
            }
            catch (SqlException sqlEx) {
                Console.WriteLine("Error occur when connect to Database.");
                Console.WriteLine($"Error reason:{sqlEx.Message}");
            }
            return connection;
        }
    }
}
