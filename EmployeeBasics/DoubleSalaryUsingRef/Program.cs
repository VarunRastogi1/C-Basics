using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleSalaryUsingRef
{
    internal class DoubleSalaryUsingRef
    {
        public static void Double(ref int oldSalary)
        {
            oldSalary = oldSalary + oldSalary;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the last salary");
            int newSalary = Convert.ToInt32(Console.ReadLine());
            Double(ref newSalary);

            Console.WriteLine(newSalary);
            Console.ReadLine();
        }

    }
}
