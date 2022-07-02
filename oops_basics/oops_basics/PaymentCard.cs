using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_basics
{
    public class PaymentCard
    {
        public double OpeningBalance { get; set; }
        public PaymentCard(double openingBalance)
        {
            OpeningBalance = openingBalance;    
        }

        public override string ToString()
        {
            return $"The card has a balance of {OpeningBalance} Euros";
        }

        public void EatLunch()
        {
            if (OpeningBalance >= 10.60)
            {
                OpeningBalance -= 10.60;
                Console.WriteLine("Current balnce after eating lunch is " + OpeningBalance + " euros");
            }
        }
        public void DrinkCoffee()
        {
            if (OpeningBalance >= 2)
            {
                OpeningBalance -= 2;
                Console.WriteLine("Current balnce after drinking coffee is " + OpeningBalance + " euros");
            }
        }

        public void ChargeCard(double topUp)
        {
            if(OpeningBalance+ topUp> 15)
            {
                OpeningBalance = 15;
                Console.WriteLine();
            }
            else
            {
                OpeningBalance += topUp;
            }
            Console.WriteLine("Current balance after charging " + OpeningBalance + " euros");
        }
    }
}
