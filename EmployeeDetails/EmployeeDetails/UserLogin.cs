using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class UserLogin
    {       
        static public void GetUserCredentialsAndLogin()
        {
            int retry = 0;
            do
            {
                Console.WriteLine("Enter Username");
                int username = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Password");
                int pwd = int.Parse(Console.ReadLine());
                if (username == 12 && pwd == 1234)
                {
                    Console.WriteLine("Login Successful");
                    break;
                }
                else
                {
                    Console.WriteLine("Login Failed");
                    retry++;
                }
            } while (retry < 3);
        }
    }
}
