using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_basics
{
    public class Book
    {
        public string Title { get; set; }
        public int PageCount { get; set; }

        public int PublicationYear { get; set; }

        public Book(string title,int pageCount, int publicationYear)
        {
            Title= title;
            PageCount= pageCount;
            PublicationYear= publicationYear;
        }

    }
}
