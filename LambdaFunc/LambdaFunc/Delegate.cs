using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate int func(ref int x);
public delegate string func1();
namespace LambdaFunc
{
    internal class Delegate1   
    {
        static int d = 4;
        public Delegate1()
        {

             Ref(ref d);
            Console.WriteLine(d); 
        }
        public static int Ref(ref int x)
        {
            int i = 0;
            x = 1; Get(i);
            return x = (i++) + (++i);// 0 + 2 
        }
        public static void Get(int i)
        {
            i = 5 + 10;
        }

    }

   

}
