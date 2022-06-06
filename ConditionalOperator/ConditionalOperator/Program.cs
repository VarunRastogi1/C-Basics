using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a>0 ? "a is positive": "a is not positive");
            Console.WriteLine(b > 0 ? "b is positive": "b is not positive");
            Console.WriteLine((b > 0) && (a>0) ? "both are positive" : "both are not positive");
            Console.ReadLine();


        }
    }
}
