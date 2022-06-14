using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingEmployees_with_ConditionalOperator
{
    internal class ComparingEmployees
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rating of employee A");
            int ratingA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter rating of employee B");
            int ratingB = int.Parse(Console.ReadLine());
            Console.WriteLine(ratingA > 3 ? "A is good" : "A is not good");
            Console.WriteLine(ratingB > 3 ? "B is good" : "B is not good");
            Console.WriteLine((ratingA > 3) && (ratingB > 3) ? "both are good" : "Either one or both are not good");
            Console.ReadLine();
        }
    }
}
