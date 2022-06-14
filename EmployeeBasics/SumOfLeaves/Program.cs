using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfLeaves
{
    internal class SumOfLeaves
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter month-wise leaves as a string");     //eg. 231142213501
            string leaves = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < leaves.Length; i++)
            {                                                   //i REPRESENTS THE POSITION OF SUBSTRING
                sum += Convert.ToInt32(leaves.Substring(i, 1));     //1 REPRESENTS THE LENGTH OF SUBSTRING
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
