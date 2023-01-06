using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace SimpleCRUDDemo
{
     class Program
    {
        static void Main(string[] args) {
            DBOperation dBOperation = new DBOperation();
            string select = "";
            do {
                ShowMenu();
                select = Console.ReadLine();//1
                switch (select) {
                    case "1": {
                            //C-Create 
                            UserModel user = new UserModel {
                                Id = 8,
                                Name = "Aye Aye",
                                Email = "ayeaye@gmail.com",
                                Password = "aye@123",
                                IsDelete = false,
                                CreatedDate = DateTime.Now
                            };
                          bool saveProcess=  dBOperation.SaveUser(user);
                            if (saveProcess) {
                                Console.WriteLine("save process is complete successfully!");
                            }
                        }
                        break;
                    case "2": {
                            //R-Reterive process 
                            List<UserModel> users = dBOperation.GetAllUser();//get all of the record with list object 
                            //printing out all of the records from the list object by using foreach loop.
                            Console.WriteLine("User Information as Below!!");
                            Console.WriteLine("Id\tName\tEmail\t\tIsDelete\tCreatedDate");
                            Console.WriteLine("================================================");
                            foreach (UserModel u in users) {
                                Console.WriteLine(u.Id + "\t" + u.Name + "\t" + u.Email + "\t" + u.IsDelete + "\t" + u.CreatedDate);
                            }
                            Console.WriteLine("================================================");
                            break;
                        }
                    case "3": {
                            //U-Update process 
                            UserModel updateUser = new UserModel {
                                Id = 8,
                                Name = "Aye Aye Aung",
                                Email = "susuaye@gmail.com"
                            };
                            bool updateProcess = dBOperation.UpdateUser(updateUser);
                            if (updateProcess) {
                                Console.WriteLine("update process is complate successfully!");
                            }
                            break;
                        }
                    case "4": {
                            //Delete process in Here
                            bool deleteProess = dBOperation.DeleteUser(8);
                            if (deleteProess) {
                                Console.WriteLine("delete process is complete successfully!!");
                            }
                        }
                        break;
                }
            } while (select !="5");
            Console.WriteLine("Good Bye!!");
            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }//end of main method 

        public static void ShowMenu() {
            Console.WriteLine("Please Select Operation");
            Console.WriteLine("1:Create User Process!");
            Console.WriteLine("2:Reterive User Process!");
            Console.WriteLine("3:Update User Process!");
            Console.WriteLine("4:Delete User Process!");
            Console.WriteLine("5:Exist from the application!");
        }
    }
}
