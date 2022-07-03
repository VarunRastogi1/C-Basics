using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class MaxMinRating: RatingArray
    {
        
        public void ShowMaxRating()
        {
            int MaxRating = Arr[0];
            for (int i = 0; i < NumEmp; i++)
            {
                if (MaxRating < Arr[i])
                {
                    MaxRating = Arr[i];
                }
            }
            Console.WriteLine("Maximum Rating={0}", MaxRating);
        }
        public void ShowMinRating()
        {
            int minRating = Arr[0];
            for (int i = 0; i < NumEmp; i++)
            {
                if (minRating > Arr[i])
                {
                    minRating = Arr[i];
                }
            }
            Console.WriteLine(" Minimum Rating={0}", minRating);
        }
       
    }
}
