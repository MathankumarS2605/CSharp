using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class NameCheck
    {
        public static void Check()
        {
                        Console.WriteLine("Enter the name:");
            String name=Console.ReadLine();
            char[] charArr=name.Trim().ToLower().ToCharArray();

            if(charArr.Length < 8)
            {
                Console.WriteLine("Enter the valid name");

            }
            for(int i = 0; i < charArr.Length; i++) {
                if (charArr[i] >= 97 && charArr[i] <= 122)
                {

                 }
            }
        }
    }
}
