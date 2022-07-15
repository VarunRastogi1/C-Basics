using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Borrowing
    {
        public int Id { get; set; }
        public string BookName { get; set; }  
        public string Borrower { get; set; }
        public string DateBorrowed { get; set; }
        public string DateDue { get; set; }
        public void Create()
        {
            Book b= new Book();                          //Composition with Book

            Student student= new Student();              //Composition with Student
        }
        public void Update()
        {

        }


    }
}
