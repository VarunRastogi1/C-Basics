using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element{0}",i+1);
                int data= Convert.ToInt32(Console.ReadLine());
                arr[i]=data;
            }
            Console.WriteLine("-------------------------Your Entered Data---------------------------");
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------Your Entered Data in Reverse Order---------------------------");
            for (int i = n-1;i >= 0;i--)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
