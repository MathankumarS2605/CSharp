using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayTwo
{
    internal class StringLessons
    {
        public static void DemoA()
        {
            //String firstString = "Hello";
            //char[] data = { 'H', 'e', 'l', 'l', 'o' };
            //String secondString = new string(data);
            //Console.Write(firstString + " " + secondString);
            //String thirdString = String.Empty;
            //int x = 0;
            //String s1 = "Tom and Jerry are good friends";
            //String[] words = s1.Split(' ');
            //Console.WriteLine("Length " + words.Count());

            //foreach (var c1 in words)
            //{
            //    Console.WriteLine(c1);
            //}

            //String firstString = "Tom and Jerry are good friends";
            //String stringInUpper = firstString.ToUpper();
            //Console.WriteLine("firstString : "+firstString);
            //Console.WriteLine("stringInUpper : "+stringInUpper);
            //String stringInLower = firstString.ToLower();
            //Console.WriteLine("firstString: "+firstString);
            //Console.WriteLine("stringInLower: "+stringInLower);
        }
        public static void DemoB() {
            String secondString = "    abcdef    ffjjfjf";
            String trimmedString = secondString.Trim();
            Console.WriteLine(secondString);
            Console.WriteLine("secondString Length: " + secondString.Length);
            Console.WriteLine(trimmedString);
            Console.WriteLine("trimmedString Length: " + trimmedString.Length);
            String trimmedAtEnd = secondString.TrimEnd();
            Console.WriteLine(trimmedAtEnd);
            Console.WriteLine("trimmedAtEnd Length: " + trimmedAtEnd.Length);
            String trimmedAtStart = secondString.TrimStart();
            Console.WriteLine(trimmedAtStart);
            Console.WriteLine("trimmedAtStart Length: " + trimmedAtStart.Length);
        }
        public static void DemoC()
        {
            {
                String s1 = "It looks like September is going to have more rain";
                Console.WriteLine(s1);
                Console.WriteLine("Length " + s1.Length);
                String s2 = s1.Substring(5);
                Console.WriteLine(s2);
                Console.WriteLine("s2 Length " + s2.Length);
                String s3 = s1.Substring(5, 10);
                Console.WriteLine(s3);
                Console.WriteLine("s3 Length " + s3.Length);
            }





        }
        public static void SortingStrings()
        {
            //sort the names
            String[] names = new String[5];
            names[0] = "Xavier";
            names[1] = "Basker";
            names[2] = "Anandh";
            names[3] = "John";
            names[4] = "anandh";



            //String temp;
            String temp = String.Empty;
            int len = names.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < (len - 1); j++)
                {
                    if (names[j].CompareTo(names[j + 1]) < 0)
                    {
                        temp = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp;
                    }//b,x,A,J,a
                }
            }
            for (int i = 0; i < len; i++)
            {
                Console.Write(names[i] + ",");
            }
        }
        public static void ModifyNumberMultipleTimes()
        {
            int begin = DateTime.Now.Millisecond;
            double x = 100;
            for (int i = 1; i < 1000000; i++)
            {
                x += i;
            }
            int after = DateTime.Now.Millisecond;
            Console.WriteLine(after - begin);
            Console.WriteLine(x);
        }

    }
}
