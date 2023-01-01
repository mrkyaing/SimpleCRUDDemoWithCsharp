using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRUDDemo
{
     class Program
    {
        static void Main(string[] args) {
        DBOperation dBOperation= new DBOperation();
         List<UserModel> users= dBOperation.GetAllUser();//get all of the record with list object 
         //printing out all of the records from the list object by using foreach loop.
         foreach(UserModel u in users) {
                Console.WriteLine(u.Id+" "+u.Name+" "+u.Email+" "+ u.IsDelete+" "+u.CreatedDate);
            }
            UserModel user = new UserModel {
                Id=101,
                Name="Su SU",
                Email="susu@gmail.com",
                Password="susu@123",
                IsDelete=false,
                CreatedDate=DateTime.Now
            };
            //dBOperation.SaveUser(user);
            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
