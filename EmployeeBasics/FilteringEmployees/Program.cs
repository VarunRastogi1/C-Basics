using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringEmployees
{
    internal class FilteringEmployees
    {
        static void Main(string[] args)
        {
            for (int employeeId = 1; employeeId <= 500; employeeId++)
            {
                if (employeeId % 15 == 0)       //print employees whose ID is multiples of 3 and also 5.
                {
                    Console.WriteLine(employeeId);
                    Console.ReadLine();

                }
            }
        }
    }
}
