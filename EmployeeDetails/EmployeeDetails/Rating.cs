using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class Rating
    {
        public static float AppraisalFunction(int factor)

        {
            float rating = factor * factor - 2 * factor + 1;
            return rating;
        }
    }
}
