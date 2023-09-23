using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Arrays
{
    internal class Anagram
    {
        public static void CheckAnagram(String name)
        {
          String[] words=name.Trim().Split(' ');
            int k = 0;
            String[] res=new string[words.Length];
          foreach (String word in words)
            {
                char[] chars = word.ToCharArray();
                 Array.Sort(chars);
                String str1=new string(chars);
                res[k++] = str1;
            }

        }

    }
}
