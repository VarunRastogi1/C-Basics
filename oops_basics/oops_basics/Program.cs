// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace oops_basics
{
    public class Program
    {
        public static void Main(string[] args)
        {
        
            Student s1 = new Student(1, "VARUN", "RASTOGI", 9, "BTECH");
            ShowDetails(s1);
            Console.ReadLine();
        

            string myTitle;
            int myPageCount;
            int myPublicationYear;

            List<Book> books = new List<Book>();
            while(true)
            {
                myTitle = Console.ReadLine();
                if(myTitle == "")
                {
                    break;
                }
                myPageCount= int.Parse(Console.ReadLine());
                myPublicationYear= int.Parse(Console.ReadLine());
                Book myBook = new Book(myTitle, myPageCount, myPublicationYear);
                books.Add(myBook);
            }
            Console.WriteLine("what are you looking for");
            string search= Console.ReadLine();
            for (int i = 0; i < books.Count; i++)
            {
                if (search == "everything")
                {
                    foreach (Book obj in books)
                    {
                        Console.WriteLine(obj.ToString());
                    }
                    break;
                }
                else if (search == books[i].Title)
                {
                    Console.WriteLine($"Title: {books[i].Title} PageCount: {books[i].PageCount} PublicationYear: { books[i].PublicationYear}");
                }
            }
            var card = new PaymentCard(15);
            card.EatLunch();
            card.DrinkCoffee();
            Console.WriteLine(card.ToString());
            card.ChargeCard(10);
            Console.ReadLine();
        }
        public static void ShowDetails(Student s1)
        {
            Console.WriteLine("Name: " + s1.FirstName + " " + s1.LastName + " GPA: " + s1.GPA);
        }
    }
}
