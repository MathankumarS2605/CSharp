using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingTheC_
{
    internal class Lambda
    {
        public static void lambda()
        {
            // () => Console.WriteLine("Hii"); 
            var t = () => { Console.WriteLine("hi"); };
            t();
            hi();
    }
        public static void hi()
        {
            Console.WriteLine("From Hi");
        }
            
    }
}

