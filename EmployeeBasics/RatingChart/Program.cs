using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingChart
{
    internal class RatingChart
    {
        static void Main(string[] args)
        {
            int lowerLimit = Convert.ToInt32(Console.ReadLine());
            int upperLimit = Convert.ToInt32(Console.ReadLine());
            for (int factor = lowerLimit; factor < upperLimit; factor++)
            {
                Console.WriteLine(factor * factor - 2 * factor + 1);
                Console.ReadLine();
            }

        }
    }
}
