using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream
{
    internal class STreamReadreWrite
    {
        static byte[] storage = new byte[255];
        static MemoryStream temporaryStream = new MemoryStream(storage);

        public static void MemStreamWriter()
        {
            // Wrap tempmemorystream in a reader and a writer.
            StreamWriter streamwriter = null;
            // Write to storage, through streamwriter.
            String inputString;
            try
            {
                Console.WriteLine("Enter a Sentence:");
                inputString=(Console.ReadLine());
                streamwriter = new StreamWriter(temporaryStream);
                streamwriter.WriteLine(inputString);
               
                 
                 
                // Put a period at the end.
                streamwriter.WriteLine(".");
                streamwriter.Flush();
                  
                streamwriter.WriteLine(inputString);
                Console.WriteLine("tempmemorystream.Length " + temporaryStream.Length);
                Console.WriteLine("tempmemorystream.Capacity " + temporaryStream.Capacity);
                Console.WriteLine("tempmemorystream.Postion " + temporaryStream.Position);
            }
            catch (Exception err)
            {
                Console.WriteLine("ERROR!!! " + err.Message);
            }
            finally
            {
                //streamwriter.Close();
            }
        }
        public static void MemStreamReader()
        {
            Console.WriteLine("memstrm.Postion " + temporaryStream.Position);
            StreamReader memrdr = new StreamReader(temporaryStream);
            try
            {
                Console.WriteLine("\nReading through memrdr: ");
                // Read from tempmemorystream using the stream reader.
                temporaryStream.Seek(0, SeekOrigin.Begin); // reset file pointer
                Console.WriteLine("tempmemorystream.Postion After seek " + temporaryStream.Position);
                string str = memrdr.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    //if (str.CompareTo(".") == 0) break;
                    str = memrdr.ReadLine();
                }
            }
            finally
            {
                memrdr.Close();
            }
        }


    }
}
