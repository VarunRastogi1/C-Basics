using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements");
            int n= Convert.ToInt32(Console.ReadLine());
            int[] arr= new int[n];
            int sum = 0;
            for (int i =0;i <n; i++)
            {
                Console.WriteLine("Enter element {0}",i+1); 
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + arr[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
