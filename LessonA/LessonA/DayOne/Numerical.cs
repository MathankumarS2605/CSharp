using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.ClassWork
{
    internal class Numericals
    {
        public static void Pyramid(int row)
        {
            int col = 2*row - 1;
            int mid = (col / 2) + 1;
            for (int i=1;i <= row; i++)
            {
                for(int j=1;j<= col;j++)
                {
                    Console.WriteLine("*");

                }
            }

            
        }   
        public static void Key()
        {
            Console.WriteLine("hell0");
        }
    }
}
