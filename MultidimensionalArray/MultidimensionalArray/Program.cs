using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns");
            int m= int.Parse(Console.ReadLine());
            int[][] arr=new int[n][];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Enter element {0}-{1}", i+1, j+1);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine(arr[i][j]);
                }
            }
            Console.ReadLine();


        }
        
    }
}
