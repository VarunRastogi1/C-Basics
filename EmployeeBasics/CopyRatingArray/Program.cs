using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyRatingArray
{
    internal class CopyRatingArray
    {
        static void Main(string[] args)
        {
            int[] ratingLastYear = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter last year rating of employee {0}", i + 1);
                ratingLastYear[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] ratingThisYear = new int[ratingLastYear.Length];
            for (int i = 0; i < ratingThisYear.Length; i++)
            {
                ratingThisYear[i] = ratingLastYear[i];
            }

            Console.WriteLine("--------------After copy the ratings of last year-------------");
            for (int i = 0; i < ratingThisYear.Length; i++)
                Console.WriteLine(ratingThisYear[i]);
            Console.ReadLine();

        }
    }
