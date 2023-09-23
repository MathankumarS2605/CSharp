using System.Text;

namespace FirstMVCApp.Models
{
    public class AuthorRepository
    {
        public static Dictionary<int,Author> GetAuthorDictionary()
        {
            string fName = @"C:\temp\Author.txt";
            Dictionary<int,Author> list = new Dictionary<int,Author>();
            bool isFileExits = System.IO.File.Exists(fName);
            if (isFileExits)
            {
                using (StreamReader streamReader = new StreamReader(fName))
                {
                    String str = $"{streamReader.ReadLine()}";
                    String[] data = str.Split(',');
                    Author author = null;
                    if(data.Length == 5)
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.id, author);
                        while (!streamReader.EndOfStream)
                        {
                            str=streamReader.ReadLine().ToString();
                            data=str.Split(",");
                            if(data.Length == 5)
                            {
                                author=StringToAuthor(data, new Author());
                                list.Add(author.id, author);
                            }
                        }
                    }
                }
            }
           
            return list;    

        }
        //public static Author StringToAuthor(string[] data,Author author) { }
          public static Author FindAuthorById(int id) {
            Dictionary<int,Author> list=AuthorRepository.GetAuthorDictionary(); 
            Author author = null;
            if(list != null)
            {
                //author= list.FirstOrDefault(x => (x.Key == id)).Value; 
                if (list.ContainsKey(id))
                {
                    author = list[id];
                }
            }
            return author;
        }
        public static void  SaveToFile(Author author) {
            string fname = @"C:\temp\Author.txt";
            string content=$"{author.id},{author.Name},{author.Date1},{author.No_of_books_published},{author.Royalty}";
            using (StreamWriter sw = new StreamWriter(fname,false))
            {
                sw.WriteLine(content);
            }
		}

        public static void UpdateAuthorToFile(Author pAuthor)
        {
            String fname = @"C:\temp\Author.txt";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            string strAuthor = String.Empty;
            using (StreamWriter sr = new StreamWriter(fname))
            {
                foreach (Author author in list.Values)
                {
                    if (author.id != pAuthor.id)
                    {
                        strAuthor = $"{author.id},{author.Name},{author.Date1},{author.No_of_books_published},{author.Royalty}";
                    }
                    else
                    {
                        strAuthor = $"{pAuthor.id},{pAuthor.Name},{pAuthor.Date1},{pAuthor.No_of_books_published},{pAuthor.Royalty}";
                    }
                    sr.WriteLine(strAuthor);
                }
               
            }
        }
        public static void DeleteAuthor(Author author) {
            string fName = @"c:/temp/Author.txt";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            StringBuilder sb = new StringBuilder(list.Count + 100);
            foreach (Author authors in list.Values)
            {
                if (author.id != authors.id)
                {
                    sb.Append($"{author.id},{author.Name},{author.Date1},{author.No_of_books_published},{author.Royalty}");
                }
                System.IO.File.WriteAllText(fName, sb.ToString());
            }
        }
  
     //   public static void RemoveAuthor(int id) { }
        //public static SaveAllAuthorsToFile(Dictionary<int, Author> authorDictionary) {

        //}
        private static Author StringToAuthor(String[] data, Author author)
        {
            author.id = int.Parse(data[0]);
            author.Name= data[1];
            author.Date1 = DateTime.Parse(data[2]);
            author.No_of_books_published = int.Parse(data[3]);
            author.Royalty = data[4];
            return author;

        }
    }
}
