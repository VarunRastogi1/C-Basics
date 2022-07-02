// See https://aka.ms/new-console-template for more information
using System;
namespace oops_basics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string myTitle="book";
            int myPageCount;
            int myPublicationYear;

            for(int i=0; myTitle == "";i++)
            {
                myTitle = Console.ReadLine();
                myPageCount= int.Parse(Console.ReadLine());
                myPublicationYear= int.Parse(Console.ReadLine());
                Book myBook = new Book(myTitle, myPageCount, myPublicationYear);
            }


            var card = new PaymentCard(15);
            card.EatLunch();
            card.DrinkCoffee();
            Console.WriteLine(card.ToString());

            card.ChargeCard(10);
        }       
    }
}
