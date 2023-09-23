using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Analgram
    {
        public static void Anal(String name)
        {
            String[] word = name.Trim().Replace(".", "").Split(" ");
            String[] strings = new string[word.Length];
            int count = 0;
            String sort = "";
            int temp = 0;
            for(int i = 0; i < word.Length; i++)
            {
                for(int j = i + 2; j < word.Length - 1; j++)
                {
                    if (word[i].Length == word[j].Length)
                    {
                        char[] chars = word[i].ToCharArray();
                        char[] chars2 = word[j].ToCharArray();
                        Array.Sort(chars);
                        Array.Sort(chars2);

                        for (int k = 0; k < chars2.Length; k++)
                        {
                            if (chars[k] == chars2[k])
                            {
                                count++;
                                if(count == chars2.Length)
                                {
                                    foreach(char c in chars2)
                                    {
                                        sort = c + sort;
                                    }
                                    strings[temp++] = sort;
                                    sort=String.Empty;
                                    count = 0;
                                    
                                }
                            }
                        }
                    }
                }
            }
            for(int i=0;i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }
        
    }
    
    }
}
//String[] words=name.Trim().Replace(".","").Split(" ");
//String[] sortWords = new String[words.Length];
//String[] finalWords=new string[words.Length];
//int[] index=new int[words.Length];
//int k = 0;
//int l = 0;
//int m = 0;
//String sort="";
//for(int i = 0; i < words.Length; i++)
//{
//    char[] charArray= words[i].ToCharArray();

//        Array.Sort(charArray);
//    for (int j = 0; j < charArray.Length; j++)
//    {
//        sort = charArray[j]+sort;
//    }
//    charArray[0] = '\0';
//    sortWords[k++] = sort;
//    sort = String.Empty;
//}

//for(int i = 0; i < sortWords.Length; i++)
//{
//    for(int j=i+1;j< sortWords.Length-1; j++)
//    {
//        if (sortWords[i] == sortWords[j])
//        {
//            index[m++] = i;
//        }
//    }
//}
//for(int i= index.Length - 1; i >= 1; i--)
//{
//    if (index[i] == 0)
//    {
//        index[i] = -1;
//    }
//}
//for(int i =0;i<index.Length;i++)
//{
//    if (index[i] != -1)
//    {

//        Console.WriteLine( words[index[i]]);
//    }
//}