using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingTheC_
{
    internal class MemoryAllocate
    {
        static MemoryStream Memory=new MemoryStream();
        
        public static void TestMemoryWriter()
        {
            int sum = 0;
            int Length=int.Parse(Console.ReadLine());
            int[] a = new int[Length];
            for(int i=0;i<Length; i++)
            {
                a[i] = i;
                sum+= a[i];
            }
           // Console.WriteLine(Memory.Capacity);
            // Console.WriteLine(sum);
            BinaryWriter binaryWriter = new BinaryWriter(Memory);
            
            String ip=sum.ToString();
            byte[] arr= Encoding.ASCII.GetBytes(ip);
            binaryWriter.Write(arr);
            Console.WriteLine(Memory.Capacity);
            Console.WriteLine(Memory.Length);
            Console.WriteLine(Memory.Position);

        }
        public static void TestMemoryReader()
        {
            if(Memory.Length == -1) {
                Console.WriteLine("Unable to Fetch");
            }
            
             BinaryReader binaryReader = new BinaryReader(Memory);
              binaryReader.BaseStream.Position = 0;
            int a = (int)Memory.Length;
              byte[] bytes1 = binaryReader.ReadBytes(a);
              String res=Encoding.ASCII.GetString(bytes1);    
              Console.WriteLine(res);
                //Memory.Seek(0, SeekOrigin.Begin);
                //String a= streamReader.ReadLine();
                //Console.WriteLine(a);
            
        }
        public static void PeekAndReadCharacters()
        {
            string readerText = "Tom and Jerry is an American animated media franchise and series of comedy short films created in 1940 by William Hanna and Joseph Barbera.\n" +
                " Best known for its 161 theatrical short films by Metro-Goldwyn-Mayer, the series centers on the rivalry between the titular characters of a cat named Tom and a mouse named Jerry.\n " +
                "Many shorts also feature several recurring characters.";



            Console.WriteLine("Original text:\n\n{0}", readerText);
            Console.WriteLine("*****************************************");
            StringReader strReader = new StringReader(readerText);
            // Peek to see if the next character exists
            try
            {
                int i = 0;
                while (strReader.Peek() > -1)
                {
                    i = i + 1;
                  //  Console.WriteLine(strReader.Peek());
                    // Read a line from the Stream and display it on the console
                    Console.WriteLine(strReader.ReadLine() + "--");
                  //  Console.WriteLine(strReader.Peek());
                }
                Console.WriteLine(i);
                Console.WriteLine("Data Read Complete!");
            }
            finally
            {
                //Close the stringReader
                strReader.Close();
            }
        }
    }
   
}
