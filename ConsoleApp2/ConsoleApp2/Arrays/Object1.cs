using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Arrays
{
    internal class Object1
    {
        public static void object3()
        {
            Object[] ob=new Object[10];
            Object f = "hello";
            Object h = 1;
            ob[0] = true;
            ob[1] = 1;
            ob[2] = "hello";
            ob[3] = new Object1();
            for(int i = 0;i < ob.Length; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine(ob[i]);
                }
            }
        }
    }
}
