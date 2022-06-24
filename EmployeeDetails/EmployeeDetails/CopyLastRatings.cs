using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class CopyLastRating
    {
        int[] ratingLastYear = new int[5];
        int[] ratingThisYear = new int[5];
        public void GetLastYearRating()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter last year rating of employee {0}", i + 1);
                ratingLastYear[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void CopyRating()
        {         
            for (int i = 0; i<ratingThisYear.Length; i++)
            {
                ratingThisYear[i] = ratingLastYear[i];
            }
        }
        public void ShowThisYearRating()
        {
            Console.WriteLine("--------------After copy the ratings of last year-------------");
            for (int i = 0; i < ratingThisYear.Length; i++)
            {
                Console.WriteLine(ratingThisYear[i]);
                Console.ReadLine();
            }
        }
    }
    
}
