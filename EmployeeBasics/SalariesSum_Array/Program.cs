using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalariesSum_Array
{
    internal class SalariesSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of employees");
            int numEmp = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[numEmp];
            int sumSalary = 0;
            for (int i = 0; i < numEmp; i++)
            {
                Console.WriteLine("Enter salary of employee {0}", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sumSalary = sumSalary + arr[i];
            }
            Console.WriteLine(sumSalary);
            Console.ReadLine();

        }
    }
}
