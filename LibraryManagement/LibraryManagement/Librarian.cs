using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Librarian:User
    {
        public string Department { get; set; }

        public void EnableUser(Transaction t)                   //Associstion with Transaction
        {

        }
        public void DisableUser(Transaction t)
        {

        }

    }
}
