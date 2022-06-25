using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class CopyLastRating
    {
        int[] RatingLastYear = new int[5];
        int[] RatingThisYear = new int[5];
        public void GetLastYearRating()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter last year rating of employee {0}", i + 1);
                RatingLastYear[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void CopyRating()
        {         
            for (int i = 0; i<RatingThisYear.Length; i++)
            {
                RatingThisYear[i] = RatingLastYear[i];
            }
        }
        public void ShowThisYearRating()
        {
            Console.WriteLine("--------------After copy the ratings of last year-------------");
            for (int i = 0; i < RatingThisYear.Length; i++)
            {
                Console.WriteLine(RatingThisYear[i]);
                Console.ReadLine();
            }
        }
    }
    
}
