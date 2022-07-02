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
            OpeningBalance -= 10.60;
        }
        public void DrinkCoffee()
        {
            OpeningBalance -= 2;
        }
    }
}
