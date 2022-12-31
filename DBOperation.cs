using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRUDDemo
{
    public class DBOperation
    {
        public List<UserModel> GetAllUser() {
            List<UserModel> users=new List<UserModel>();
            SqlConnection sqlConnection = DatabaseConnection.GetSqlConnection();
            string query = "select * from users";
            SqlCommand sqlCommand=new SqlCommand(query,sqlConnection);
            SqlDataReader reader=sqlCommand.ExecuteReader();
            while (reader.Read()) {
                Console.WriteLine(reader[0]);
            }
            return users;
        }
    }
}
