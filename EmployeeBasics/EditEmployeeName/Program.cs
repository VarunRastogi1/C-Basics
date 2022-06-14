using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditEmployeeName
{
    internal class EditEmployeeName
    {
        public static void Modify_character(string name, int position, string character)
        {
            name = name.Remove(position, 1);
            name = name.Insert(position, character);
            Console.WriteLine(name);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter position");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Character");
            string character = Console.ReadLine();
            Modify_character(name, position, character);
            Console.ReadLine();

        }
    }
}
}
