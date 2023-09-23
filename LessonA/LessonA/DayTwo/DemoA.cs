using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayTwo
{
    internal class DemoA
    {   //Global Variable
        static int x = 123;
        int y = 1000;
        public static void FirstMethod()
        {  //Local Variable 
            int x = 203;
          //  x = DemoA.x;
            Console.WriteLine(x);
            Console.WriteLine(DemoA.x);
        }
        public void SecondMethod()
        {
            Console.WriteLine(y);
        }
    }
    internal class DemoB
    {

    }

}
namespace LessonA.Gavs
{
    internal class DemoA
    {

    }

}

