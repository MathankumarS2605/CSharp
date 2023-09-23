using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayTwo
{
    internal class Box
    {
        public int height;
        public static  int width;
        public const String type = "Wooden";//can't be modified ......
        //public static int GetHeight() { 
        //    return height; 
        //}
        public  int GetHeight()
        {
            return width;
        }

    }
    internal class TestBox
    {
        
               
        public static void TestOne()
        {
            
            Box.width = 100;
            Box firstBox =new Box();
            firstBox.height = 12345;  
            Box secondBox=new Box();
            secondBox.height = 6789;
            Console.WriteLine(Box.type);
            Console.WriteLine($"First Box {firstBox.height},{Box.width}");
            Console.WriteLine();
            Box.width = 200;
            Console.WriteLine($"First Box {firstBox.height}" + " " + Box.width);
            

        }
    }
}
