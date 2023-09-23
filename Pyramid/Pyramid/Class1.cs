using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    internal class Class1
        
    {
        public  Class1(){

            Console.WriteLine("Exclusive");
        }
        public sealed void Hello()
        {
            Console.WriteLine("7");
        }
    }
    internal class Class2 : Class1
    {
          public  void Hello()
        {
            Console.WriteLine("Hi mathan");
        }

    }
    internal class Check

    {
        public static void Check1()
        {
            Class1 class1 = new Class1();
            class1.Hello();

        }

    }
}