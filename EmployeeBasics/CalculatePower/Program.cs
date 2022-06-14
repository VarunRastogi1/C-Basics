using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePower
{
    internal class CalculatePower
    {
        public static int Power(int number, int exponent)
        {
            int num = 1;
            for (int i = 0; i < exponent; i++)
            {
                num *= number;
                continue;
            }
            return num;
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
