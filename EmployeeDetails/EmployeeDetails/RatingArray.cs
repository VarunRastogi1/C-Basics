using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class RatingArray
    {
        public int NumEmp;
        public int[] Arr = new int[100];
        public void GetEmployeeCount()
        {
            Console.WriteLine("Enter number of Employees");
            NumEmp = Convert.ToInt32(Console.ReadLine());           
        }       

        public void GetRatings()
        {           
            for (int i = 0; i < NumEmp; i++)
            {               
                Console.WriteLine("Enter rating of employee {0}", i + 1);
                int rating = Convert.ToInt32(Console.ReadLine());
                Arr[i] = rating;
            }
        }
        public void ShowEnteredData()
        {           
            Console.WriteLine("-------------------------Your Entered Data---------------------------");
            for (int i = 0; i < NumEmp; i++)
            {
                Console.WriteLine(Arr[i]);
            }
        }
        public void ShowReverseData()
        {           
            Console.WriteLine("-------------------------Your Entered Data in Reverse Order---------------------------");
            for (int i = NumEmp - 1; i >= 0; i--)
            {
                Console.WriteLine(Arr[i]);
            }
        }
    }
}
