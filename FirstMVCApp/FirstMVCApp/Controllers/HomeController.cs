using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging.Signing;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.IO.MemoryMappedFiles;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return  View();
        }
        public IActionResult SayHello(String name)
            
        {
            if (String.IsNullOrEmpty(name)) {
                ViewData["v1"] = "Name is Empty";
            }
            else
            {
                ViewData["v1"] = name;  
            }
            return View();
        }
        
        public IActionResult Add(int x,int y)
        {
            int result = x + y;
            ViewData["Result"] = result;
            return View();
        }
        public IActionResult Multiply(int x, int y)
        {
            int result = x * y;
            ViewData["Result"] = result;
            return View("Add");
        }
        public IActionResult Divide(int x, int y)
        {
            int result = x / y;
            ViewData["Result"] = result;
            return View("Add");
        }
        public IActionResult Subtract(int x, int y)
        {
            int result = x / y;
            ViewData["Result"] = result;
            return View("Add");
        }

        public IActionResult DoLogin(String txtUser,String txtPwd)
        {
            ViewData["userValue"]=$"{txtUser},{txtPwd}";
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddNewBook()
        {
            Book book=new Book();
            return View(book);
        }
        public IActionResult SaveBook(Book pBook)
        {

            /*StringBuilder sb = new StringBuilder();
            sb.Append("BooK ID: " + ebook.BookID);
            sb.Append("\t");
            sb.Append("Book Title: " + ebook.Title);
            sb.Append("\t");
            sb.Append("Book Cost: " + ebook.Cost);
            sb.Append("\t");
            sb.Append("Book AuthorName: " + ebook.AuthorName + " , ");
            HomeController.FileWrite(sb);*/

            String fName = @"C:\Users\mathankumar.s\Documents\myfileA.txt";
            string strBook = $"{pBook.BookID},{pBook.Title},{pBook.AuthorName}\t{pBook.Cost}";
            using (StreamWriter sw = new StreamWriter(fName,true))
            {
                sw.WriteLine(strBook);
            }
            return View(pBook);
        }
           

        public static void FileWrite(StringBuilder sb) {
            string fname = @"C:\Users\mathankumar.s\Documents\myfileA.txt";
            System.IO.File.WriteAllText(fname,sb.ToString());
        }
        private Book StringToBook(String[] data,Book book)
        {
            book.BookID = int.Parse(data[0]);
            book.Title = data[1];
            book.AuthorName = data[2];
            book.Cost = int.Parse(data[3]);
            return book;    

        }

        public IActionResult ListAllBook()
        {
            string fname = @"C:\Users\mathankumar.s\Documents\myfileA.txt";
            List<Book> books = new List<Book>();
            using (StreamReader sr = new StreamReader(fname))
            {
                string strbook = $"{sr.ReadLine()}";
                String[] data = strbook.Split(',');
                Book book = StringToBook(data, new Book());
                 books.Add(book);   
                while(!sr.EndOfStream)
                {
                    strbook = $"{sr.ReadLine()}";
                    data=strbook.Split(",");    
                    book=StringToBook(data, new Book());    
                    books.Add(book);
                }
            }
            return View(books);
        }

    }
}