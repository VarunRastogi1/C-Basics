using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student ram = new Student();
            ram.Greet();
            ram.SetAge(17);
            ram.ShowAge();
            ram.study();
            Teacher Jon = new Teacher();
            Jon.Greet();
            Jon.SetAge(17);
            Jon.Explain();
            Console.ReadLine();
        }
    }
}
