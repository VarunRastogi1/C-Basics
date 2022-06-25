using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class GetDetailsAndCalculateFactor
    {

        int Factor1;
        int Factor2;
        string Operation;
        public void GetfactorDetails() { 
                
            Console.WriteLine("Enter factor1");
            Factor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter factor2");          
            Factor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation you want to perform");
            Operation = Console.ReadLine();
        }
        public int CalculateFactor() {
            switch (Operation)
            {
                case "+":
                    return  Factor1 + Factor2;
                    
                case "-":
                    return Factor1 - Factor2;
                    
                case "*":
                    return Factor1 * Factor2;
                    
                case "/":
                    return Factor1 / Factor2;
                    
                default:
                    return 0;                   
            }
        }
        
    }
}
