using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_basics
{
    public class Birthday
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public Birthday(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public int CalculateAge()
        {
            int age = DateTime.Now.Year - Year;
            return age;
        }
        public void Validate()
        {
            if (CalculateAge() > 135)
            {
                Console.WriteLine("Not Possible");
            }
            else if (CalculateAge() < 0)
            {
                throw new Exception("Invalid Value");
            }
            else
            {
                Console.WriteLine($"Your Age is {CalculateAge()}");
            }
        }
    }
}
