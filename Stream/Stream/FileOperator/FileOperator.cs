using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream.FileOperator
{
    internal class FileOperator
    {
    
        static String fName = @"C:\Users\mathankumar.s\Documents\myfileA.txt";
        public static void FileWriteAllLines()
        {
           
            string[] lines = { "Chennai is the capital city .", "Madurai is the temple city.", "Salem is the steal city." };
            try
            {
                File.WriteAllLines(fName, lines);
                Console.WriteLine("File Created");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void FileReadAllLines() { 
            string[] arr=File.ReadAllLines(fName);
            foreach(string line in arr)
            {
                Console.WriteLine(line);
            }
        }
        public static void ListDirectoryContent()
        {
            String currentDir = @"C:\Users\mathankumar.s\Documents";
            string[] fileNames = Directory.GetFiles(currentDir, "*.*");
            foreach (String name in fileNames)
            {
                Console.WriteLine(name);
            }



            string[] subdirNames = Directory.GetDirectories(currentDir, "*.*");
            foreach (String name in subdirNames)
            {
                Console.WriteLine(name);
            }
        }
        public static void ShowCurrentDirectory()
        {
            String currentworkingdirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentworkingdirectory);
            currentworkingdirectory = Environment.CurrentDirectory;
            Console.WriteLine(currentworkingdirectory);
        }
        public static void CreateDirectory()
        {
            Console.WriteLine("Enter the name of the new Directory to Create");
            String path = fName + Console.ReadLine();
            DirectoryInfo dir = Directory.CreateDirectory(path);
            Console.WriteLine("Directory Created " + dir.FullName);
        }



        public static void DeleteDirectory()
        {
            string current = @"C:\\Users\\mathankumar.s\\Documents\";
            Console.WriteLine("Enter the name of the new Directory to Delete");
            String path = current + Console.ReadLine();
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
                Console.WriteLine("Directory DELETED");
            }
            else
            {
                Console.WriteLine("Directory Not Available");
            }
        }
        public static byte[] Logo
        {
            get
            {
                byte[] __logoBytes = null;
                if(__logoBytes == null)
                {
                    __logoBytes = File.ReadAllBytes(@"C:\Users\mathankumar.s\Downloads\download.png");
                }
                return __logoBytes; 

            }
        }
        public static void StreamWriterDemo()
        {
            String fName = @"c:\temp\myfileC.txt";
            string[] lines =
            {
          "Chennai is the capital city",
          "Madurai is the Temple city",
          "Salem is the steal city"
      };
            //  StreamWriter
            //  Write one line at a time to a file.
            //  The second String is added as a new Line.
            using (StreamWriter sw = new StreamWriter(fName))
            {
                foreach (string s in lines)
                {
                    sw.WriteLine(s);
                }
            }
            System.Console.WriteLine("File Created");
        }
        

    }
}
