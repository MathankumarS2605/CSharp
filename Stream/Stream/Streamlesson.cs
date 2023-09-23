using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream
{
    internal class Streamlesson
    {
        //public static void TestOne()
        //{
        //    char ch = ' ';
        //    int x=0;
        //    //string 


        //    while (ch != 'q')
        //    {
        //        //Console.Read();
        //         Console.WriteLine("Press a key followed by Enter: ");
        //         x = Console.Read();
        //         ch = (char)x;
        //    }
        //    Console.WriteLine("Key " + x);
        //}

        public static void TestTwo()
        {
            Console.WriteLine("Enter a sentence");
            string? str = Console.ReadLine();
            Console.WriteLine(str);
        }
        public static void TestNullableTypes()
        {
            int? x = 0;
        }
    }

}
