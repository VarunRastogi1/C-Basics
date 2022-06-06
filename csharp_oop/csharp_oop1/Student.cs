using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    public class Student:Person
    {
        public void study()
        {
            Console.WriteLine("I'm studing");
        }
        public void ShowAge()
        {
            Console.WriteLine("age is {0}", age);
        }
    }
}
