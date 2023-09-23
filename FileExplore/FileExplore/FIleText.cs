using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileExplore
{
    internal class FileText
    {
        static String fname = @"C:\Users\mathankumar.s\Documents\myfileA.txt";
        public static string[] lines = { "Chennai is the capital city", "Mumbai is the Normal Town", "Banglore is the Chemical City " };
        public static void WriteALlText()
        {
            
           
            File.WriteAllLines(fname,lines);
            Console.WriteLine("File has been created");
        }
        public static void ReadALl()
        {
            string[] read = File.ReadAllLines(fname);
            foreach (string line in read)
            {
                Console.WriteLine(line);
            }
        }
        public static void UsingStream()
        {
            using(StreamWriter stream = new StreamWriter(fname))
            {
                foreach (string l in lines)
                {
                    stream.WriteLine(l);
                }
            }
        }
        public static void UsingStreamReader()
        {
            using(StreamReader stream = new StreamReader(fname))
            {
                stream.BaseStream.Position = 0;
                String lines =stream.ReadToEnd();
                Console.WriteLine(lines);
            }
        }

        public static void UsingStringBuilder()
        {
            StringBuilder sb=new StringBuilder();
            sb.Append(lines[0]);
           // sb.Append("\n");
            sb.Append(lines[1]);
            sb.Append("\n");
            sb.Append(lines[2]);
            File.WriteAllText(fname, sb.ToString());
        }

        public static void UsingGetDirectories()
        {
            String[] dirs = Directory.GetDirectories(fname);
        }

        public static void UsingObject() { 
            Customer customer = new Customer();
            customer.Name = "Mathan";
            customer.Address = "Thanjavur";
            customer.City = "Tamil nadu";
            using (Stream stream = File.Open(fname,FileMode.Open))
            {
                BinaryFormatter bf=new BinaryFormatter();
                bf.Serialize(stream, customer);
            }
            Console.WriteLine("Completed");
        }
        public static void UsingDeserial() { 
            BinaryFormatter binaryFormatter = new BinaryFormatter();    

            using(Stream stream = File.Open(fname, FileMode.Open)) {
                Customer customer = (Customer)binaryFormatter.Deserialize(stream);
                Console.WriteLine(customer.Name);
            }
           
        }


        int s

    }
}
