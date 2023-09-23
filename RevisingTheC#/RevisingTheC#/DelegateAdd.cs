using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingTheC_
{
    public delegate int MethodHandlerA(int x, int y);
 
    internal class DelegateAdd
    {
        static event MethodHandlerA event1;
        public static void Ku()
        {
            event1 = Add;
            event1 += Sub;

            int res = event1(1, 2);
            Console.WriteLine(res);


        }

        


        public static int Add(int  x,int y)
        {
            return(x+y);
        }
        public static int Sub(int x, int y)
        {
            return(x-y);

        }

    }
}
