// See https://aka.ms/new-console-template for more information


using LibraryA;

Book book= new Book();
book.Title = "Theft";
book.Author = "Priyan";
book.Genre = "rrrr";
book.BookMarkPage(4);
Console.WriteLine(book.GetCurrentPages());
