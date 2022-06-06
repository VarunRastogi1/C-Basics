using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of an array");
            int n= int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int i;
            for ( i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int arrmax = arr[0];
            for(i=0; i<n; i++)
            { 
                if (arrmax< arr[i])
                {
                    arrmax= arr[i];
                }
            }
            int arrmin = arr[0];
            for (i = 0; i < n; i++)
            {
                if (arrmin > arr[i])
                {
                    arrmin = arr[i];
                }
            }
            Console.WriteLine("Max={0}, Min={1}", arrmax, arrmin);
            Console.ReadLine();
        }
    }
}
