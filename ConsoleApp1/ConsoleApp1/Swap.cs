using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Swap
    {
       public  static int a;
       public  static int b;
        public static void SwapOf(int v, int x)
        {
            int c = v + x;
            Swap.a = c - v;
            Swap.b = c - x;
          //  Console.WriteLine(Swap.a + "" + Swap.b);
        }

    }
}
