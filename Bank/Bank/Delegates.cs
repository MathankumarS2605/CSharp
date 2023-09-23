using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1
{
    public delegate int MethodHander(int i, int j);
    internal class Delegates
    {
       public static  int add(int i, int j)
        {
            Console.WriteLine("add called ");
            return i + j;
        }
       public static int subtract(int i, int j)
        {
            Console.WriteLine("Subtract called");
            return i - j;
        }
    }
    class Test
    {
        public static void TestOne()
        {
           MethodHander methodHander = Delegates.subtract;
            methodHander += Delegates.add;


            //int a=methodHander(1, 2);
            //int b=methodHanderb(2, 3);
         //   Console.WriteLine(a);
           
        }
    }
}
