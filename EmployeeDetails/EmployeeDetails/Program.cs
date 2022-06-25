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

            RatingRange Emp1= new RatingRange(); 
            Emp1.GetRangeDetails();
            Emp1.CalculatePossibleFactors();

            RatingArray Emp2 = new RatingArray();
            Emp2.GetEmployeeCount();
            Emp2.GetRatings();
            Emp2.ShowEnteredData();
            Emp2.ShowReverseData();

            MaxMinRating Emp3 = new MaxMinRating();
            Emp3.GetDetails();
            Emp3.ShowMinRating();
            Emp3.ShowMaxRating();

            CopyLastRating Emp4 = new CopyLastRating();
            Emp4.GetLastYearRating();
            Emp4.CopyRating();
            Emp4.ShowThisYearRating();

            Console.ReadLine();
        }
    }
}
