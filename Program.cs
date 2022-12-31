using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCRUDDemo
{
    internal class Program
    {
        static void Main(string[] args) {
        DBOperation dBOperation= new DBOperation();
            dBOperation.GetAllUser();

            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
