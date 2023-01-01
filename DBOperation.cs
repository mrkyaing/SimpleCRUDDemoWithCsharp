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
            SqlCommand sqlCommand=new SqlCommand(query,sqlConnection);//create the sqlCommand Object
            SqlDataReader row=sqlCommand.ExecuteReader();//reading  all of the data from the database by using SqlDataReader Object
            while (row.Read()) {               
                UserModel user = new UserModel {
                 Id=Convert.ToInt32(row["id"]),
                 Name = row["Name"].ToString(),
                 Email = row["Email"].ToString(),
                 IsDelete = Convert.ToBoolean(row["IsDelete"]),
                 CreatedDate = Convert.ToDateTime(row["CreatedDate"])
                };
                users.Add(user);
            }
            return users;
        }

        public bool SaveUser(UserModel user) {
            SqlConnection sqlConnection = DatabaseConnection.GetSqlConnection();
            string query = $"insert into users values({user.Id},'{user.Name}','{user.Email}','{user.Password}','{user.IsDelete}','{user.CreatedDate}')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);//create the sqlCommand Object
           int result= sqlCommand.ExecuteNonQuery();
            if (result > 0) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
