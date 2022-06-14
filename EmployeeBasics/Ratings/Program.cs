using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rating
    internal class Rating
    {
        
        public static int AppraisalFunction(int factor)

        {
            int rating= factor*factor-2*factor+1;
            return rating;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your rating factor");
            int myFactor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Rating.AppraisalFunction( myFactor));
            Console.ReadLine();
        }
    }
}
