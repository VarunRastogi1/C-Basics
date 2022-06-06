using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i= 1;i<= 500; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine(i);
                    Console.ReadLine();

                }
            }
        }
    }
}
