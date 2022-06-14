using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last5Ratings_MultiDimentionalArray
{
    internal class Last5Ratings_MultiDimentionalArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of employees");
            int numEmp = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of last ratings");
            int year = int.Parse(Console.ReadLine());
            int[][] arr = new int[numEmp][];
            for (int i = 0; i < numEmp; i++)
            {
                Console.WriteLine("Enter last {0} year rating of employee {1}", year, i + 1);
                for (int j = 0; j < year; j++)
                {
                    Console.WriteLine("Enter rating for year {0}", j + 1);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            for (int i = 0; i < numEmp; i++)
            {
                Console.WriteLine("Ratings for Employee {1}", i + 1);
                for (int j = 0; j < year; j++)
                {
                    Console.WriteLine(arr[i][j]);
                }
            }
            Console.ReadLine();


        }
    }
}
