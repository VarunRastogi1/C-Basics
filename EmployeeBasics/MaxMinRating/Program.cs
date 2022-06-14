using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinRating
{
    internal class MaxMinRating
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of employees");
            int numEmp = int.Parse(Console.ReadLine());
            int[] arrRating = new int[numEmp];
            int i;
            for (i = 0; i < numEmp; i++)
            {
                Console.WriteLine("Enter rating of employee {0}", i + 1);
                arrRating[i] = int.Parse(Console.ReadLine());
            }
            int maxRating = arrRating[0];
            for (i = 0; i < numEmp; i++)
            {
                if (maxRating < arrRating[i])
                {
                    maxRating = arrRating[i];
                }
            }
            int minRating = arrRating[0];
            for (i = 0; i < numEmp; i++)
            {
                if (minRating > arrRating[i])
                {
                    minRating = arrRating[i];
                }
            }
            Console.WriteLine("Maximum Rating={0}, Minimum Rating={1}", maxRating, minRating);
            Console.ReadLine();
        }
    }
}
