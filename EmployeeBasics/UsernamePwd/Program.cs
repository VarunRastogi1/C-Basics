using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsernamePwd
{
    internal class UsernamePwd
    {
        static void Main(string[] args)
        {

            int attempt = 0;
            do
            {
                Console.WriteLine("Enter Username");
                int Username = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Password");
                int Pwd = int.Parse(Console.ReadLine());
                if (Username == 12 && Pwd == 1234)
                {
                    Console.WriteLine("Login Successful");
                    break;
                }
                else
                {
                    Console.WriteLine("Login Failed");
                    attempt++;
                    continue;
                }
            } while (attempt < 3);
            Console.ReadLine();
        }
    }
}
