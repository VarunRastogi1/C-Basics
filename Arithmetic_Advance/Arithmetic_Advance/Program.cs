using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Calculate_values_of__Function
{
    internal class Advance
    {
        static void Main(string[] args)
        {
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            for (int i = x1; i < x2; i++)
            {
                Console.WriteLine(i * i - 2 * i + 1);
                Console.ReadLine();
            }

        }
    }
}
