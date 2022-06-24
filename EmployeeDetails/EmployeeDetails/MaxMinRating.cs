using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class MaxMinRating
    {
        int numEmp;
        int[] arrRating = new int[100];
        public void GetDetails()
        {

            Console.WriteLine("Enter number of employees");
            numEmp = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numEmp; i++)
            {
                Console.WriteLine("Enter rating of employee {0}", i + 1);
                arrRating[i] = int.Parse(Console.ReadLine());
            }
        }
        public void ShowMaxRating()
        {
            int maxRating = arrRating[0];
            for (int i = 0; i < numEmp; i++)
            {
                if (maxRating < arrRating[i])
                {
                    maxRating = arrRating[i];
                }
            }
            Console.WriteLine("Maximum Rating={0}", maxRating);
        }
        public void ShowMinRating()
        {
            int minRating = arrRating[0];
            for (int i = 0; i < numEmp; i++)
            {
                if (minRating > arrRating[i])
                {
                    minRating = arrRating[i];
                }
            }
            Console.WriteLine(" Minimum Rating={0}", minRating);
        }
       
    }
}
