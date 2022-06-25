using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            UserLogin.GetUserCredentialsAndLogin();

            GetDetailsAndCalculateFactor emp = new GetDetailsAndCalculateFactor();
            emp.GetfactorDetails();
            int factor = emp.CalculateFactor();
            Console.WriteLine("The net factor you got is "+ factor);

            Console.WriteLine("Your rating is: " + Rating.AppraisalFunction(factor));

            RatingRange emp1= new RatingRange(); 
            emp1.GetRangeDetails();
            emp1.CalculatePossibleFactors();

            MaxMinRating emp2 = new MaxMinRating();
            
            emp2.GetEmployeeCount();
            emp2.GetRatings();
            emp2.ShowEnteredData();
            emp2.ShowReverseData();
            emp2.ShowMinRating();
            emp2.ShowMaxRating();

            CopyLastRating emp4 = new CopyLastRating();
            emp4.GetLastYearRating();
            emp4.CopyRating();
            emp4.ShowThisYearRating();

            Console.ReadLine();
        }
    }
}
