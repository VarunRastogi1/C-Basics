using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class GetDetailsAndCalculateFactor
    {

        int factor1;
        int factor2;
        string operation;
        public void GetfactorDetails() { 
                
            Console.WriteLine("Enter factor1");
            factor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter factor2");          
            factor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation you want to perform");
            operation = Console.ReadLine();
        }
        public int CalculateFactor() {
            switch (operation)
            {
                case "+":
                    return  factor1 + factor2;
                    
                case "-":
                    return factor1 - factor2;
                    
                case "*":
                    return factor1 * factor2;
                    
                case "/":
                    return factor1 / factor2;
                    
                default:
                    return 0;                   
            }
        }
        
    }
}
