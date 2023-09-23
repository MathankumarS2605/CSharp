using System.Reflection.Metadata.Ecma335;

namespace LibraryA
{
    public class Book
    {
        public string Title = string.Empty;
        public string Author = string.Empty;
        public string Genre = string.Empty;
        public DateTime DateOfPublic;
        public int BookPrice;
        public int TotalPages = 300;

        public void OpenBook()
        {
            Console.WriteLine("Book is open");
        }

        public void BookMarkPage(int pageNo)
        {
            Console.WriteLine($"Page No.{pageNo} BookMarked");
        }
        public int GetCurrentPages()
        {
            Random r = new Random();
            return r.Next(TotalPages);
        }
    }
}
