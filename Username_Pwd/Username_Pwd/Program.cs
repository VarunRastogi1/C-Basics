using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Username_Pwd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int i = 0;
            do
            {
                Console.WriteLine("Enter Username");
                int Username = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Password");
                int Pwd = int.Parse(Console.ReadLine());
                if (Username==12 && Pwd==1234)
                {
                    Console.WriteLine("Login Successful");
                    break;
                }
                else
                {
                    Console.WriteLine("Login Failed");
                    i++;
                    continue;
                }
            }while(i<3);
            Console.ReadLine();
        }
    }
}
