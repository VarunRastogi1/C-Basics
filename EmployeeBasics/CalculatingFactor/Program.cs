using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingFactor
{
    internal class CalculatingFactor
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter factor1");
            int factor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter factor2");
            int factor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operation");
            char operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    Console.WriteLine("{ 0}+{1}={2}", factor1, factor2, factor1 + factor2);
                    break;
                case '-':
                    Console.WriteLine("{ 0}-{1}={2}", factor1, factor2, factor1 - factor2);
                    break;
                case '*':
                    Console.WriteLine("{ 0}*{1}={2}", factor1, factor2, factor1 * factor2);
                    break;
                case '/':
                    Console.WriteLine("{ 0}/{1}={2}", factor1, factor2, factor1 / factor2);
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }
            Console.ReadLine();

        }
    }
}
