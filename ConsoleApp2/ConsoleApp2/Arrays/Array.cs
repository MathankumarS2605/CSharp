using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Arrays
{
    internal class Array1
    {
        
        public static void FirstMethod()
        {
            int[] sample = new int[10];
            int i;
            Random random = new Random();
            for (i = 0; i < sample.Length; i++)
            {
                sample[i] = random.Next(200) ;
            }
            for (i = 0; i < sample.Length; i++)
            {
                Console.WriteLine(sample[i]);

            }
        }
        public static void SecondMethod()
        {
            int[] sample = {1,2,3,4,5,6,7,8,9,10};
            int avg, sum=0;
            for(int i=0; i<sample.Length; i++)
            {
                sum = sum + sample[i];

            }
            avg= sum/sample.Length;
            Console.WriteLine(sample.Average());
            Console.WriteLine(sample.Sum());
            Console.WriteLine(sample.Max());
            Console.WriteLine(sample.Min());
            Console.WriteLine(avg);

        }
        public static void TwoD()
        {
            int t, i;
            int[,] table = new int[3, 4];
            for(t = 0;t< 3; t++)
            {
                for(i = 0;i< 4; i++)
                {
                    table[t, i] = t * 4 + i + 1;
                }
            }
            for (t = 0; t < 3; t++)
            {
                for (i = 0; i < 4; i++)
                {
                    Console.WriteLine(table[t,i]);

                }
            }
        }
    }
}
