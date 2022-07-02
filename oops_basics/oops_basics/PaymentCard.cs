using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_basics
{
    public class PaymentCard
    {
        public int OpeningBalance { get; set; }
        public PaymentCard(int openingBalance)
        {
            OpeningBalance = openingBalance;    
        }

        public override string ToString()
        {
            return $"The card has a balance of {OpeningBalance} Euros";
        }
    }
}
