using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesFromRating
{
    internal class GradesFromRating
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rating");
            int Rating = Convert.ToInt32(Console.ReadLine());

            switch (Rating)
            {
                case 1:
                    Console.WriteLine("A+");
                    break;
                case 2:
                    Console.WriteLine("B");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("C");
                    break;
                case 5:
                case 6:
                case 7:
                    Console.WriteLine("D");
                    break;
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("E");
                    break;

                default:
                    Console.WriteLine("Invalid Rating");
                    break;
            }
            Console.ReadLine();
        }
    }
}
