using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleHikeUsingRef
{
    internal class DoubleSalary
    {
        public static int Double(int oldSalary)
        {
            return oldSalary + oldSalary;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the last salary");
            int myOldSalary = Convert.ToInt32(Console.ReadLine());
            int myNewSalary = Double(myOldSalary);
            Console.WriteLine(myNewSalary);
            Console.ReadLine();
        }
    }
}
