using ConsoleApp2.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.ArrayList1
{
    internal class WorkingWithObject
    {
        public static void TestOne()
        {
            Object objectOne = new object();
            Console.WriteLine($"ToString: {objectOne.ToString()}");
            Console.WriteLine($"HashCode: {objectOne.GetHashCode()}");
            Type typeOne = objectOne.GetType();
            Console.WriteLine($"Type: {typeOne.FullName}");



            String stringData = "WorldCup 2023";
            Console.WriteLine($"ToString: {stringData.ToString()}");
            Console.WriteLine($"HashCode: {stringData.GetHashCode()}");
            Type typeTwo = stringData.GetType();
            Console.WriteLine($"Type: {typeTwo.FullName}");
        }
        public static void TestTwo()
        {
            Emp empOne = new Emp();
            empOne.ID = 1001;
            Emp empTwo=new Emp();
            empTwo.ID = 1001; 
            Emp empThree=empOne;
            empThree.ID = 103;
            bool  flag=(empOne.Equals(empThree ));
            Console.WriteLine(flag);
            Console.WriteLine(empOne);
            Console.WriteLine(empThree);
            Console.WriteLine(empTwo.GetHashCode());
            Console.WriteLine(empThree.GetHashCode());

        }
    }
}
