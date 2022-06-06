using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for(int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] arr1= new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] =arr[i];
            }
            Console.WriteLine("--------------After copy-------------");
            for(int i = 0; i < arr1.Length; i++)
            Console.WriteLine(arr1[i]);
            Console.ReadLine();

        }
    }
}
