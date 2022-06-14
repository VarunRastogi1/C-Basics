using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePowerUsingRecursion
{
    internal class CalculatePowerUsingRecursion
    {
        public static int Power(int number, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }
            else
            {
                return number * Power(number, exponent - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int myNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter exponent");
            int myExponent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Power(myNumber, myExponent));
            Console.ReadLine();
        }
    }
}
