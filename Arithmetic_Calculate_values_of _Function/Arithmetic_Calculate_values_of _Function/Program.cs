using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Calculate_values_of__Function
{
    internal class Program
    {
        
        public static int myfunction(int x)

        {
            int y= x*x-2*x+1;
            return y;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter x");
            int myx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Program.myfunction( myx));
            Console.ReadLine();
        }
    }
}
