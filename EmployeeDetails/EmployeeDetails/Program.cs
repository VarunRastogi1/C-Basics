using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {                      
            UserLogin.GetUserCredentialsAndLogin();
            Console.ReadLine();
        }
    }
}
