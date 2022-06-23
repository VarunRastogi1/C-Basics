using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class RatingArray
    {
        int numEmp;
        int[] arr = new int[100];
        public void GetEmployeeCount()
        {
            Console.WriteLine("Enter number of Employees");
            numEmp = Convert.ToInt32(Console.ReadLine());           
        }       
        public void GetRatings()
        {           
            for (int i = 0; i < numEmp; i++)
            {               
                Console.WriteLine("Enter rating of employee {0}", i + 1);
                int rating = Convert.ToInt32(Console.ReadLine());
                arr[i] = rating;
            }
        }
        public void ShowEnteredData()
        {           
            Console.WriteLine("-------------------------Your Entered Data---------------------------");
            for (int i = 0; i < numEmp; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public void ShowReverseData()
        {           
            Console.WriteLine("-------------------------Your Entered Data in Reverse Order---------------------------");
            for (int i = numEmp - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
