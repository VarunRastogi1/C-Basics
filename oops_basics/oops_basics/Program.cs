// See https://aka.ms/new-console-template for more information
using System;
namespace oops_basics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var card = new PaymentCard(15);
            card.EatLunch();
            card.DrinkCoffee();
            Console.WriteLine(card.ToString());

            card.ChargeCard(10);
        }       
    }
}
