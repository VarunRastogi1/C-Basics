using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingArray
{
    internal class RatingArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Employees");
            int numEmp = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[numEmp];
            for (int i = 0; i < numEmp; i++)
            {
                Console.WriteLine("Enter rating of employee {0}", i + 1);
                int rating = Convert.ToInt32(Console.ReadLine());
                arr[i] = rating;
            }
            Console.WriteLine("-------------------------Your Entered Data---------------------------");
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------Your Entered Data in Reverse Order---------------------------");
            for (int i = numEmp - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
