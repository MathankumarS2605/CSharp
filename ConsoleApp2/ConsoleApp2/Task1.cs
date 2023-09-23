using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Task1
    {
            public static void Dotask(int x)
            {
                int i = x + 2000;
                x = i;
                Console.WriteLine(x);

            }
            public static void DotaskA(ref int x)
            {
                int i = x + 2000;
                x = i;
                Console.WriteLine(x);
            }
        }
}
