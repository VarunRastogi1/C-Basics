using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{   
    public class RatingRange
    {
        int LowerLimit;
        int UpperLimit;
        public void GetRangeDetails()
        {
            Console.WriteLine("Enter Lower limit of factor");
            LowerLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Upper limit of factor");
            UpperLimit = Convert.ToInt32(Console.ReadLine());
        }
        public void CalculatePossibleFactors()
        {
            Console.WriteLine("The possible factors for the provided Range are");
            for (int factor = LowerLimit; factor < UpperLimit; factor++)
            {
                Console.WriteLine(factor * factor - 2 * factor + 1);
                Console.ReadLine();
            }
        }
    }
    
}
