using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstMVCApp.Models
{
    public class Author
    {
        //Author ID,  Author Name, Author Date of Birth, No of Books
        //Published,Royalty company.

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ReadOnly(true)]
        public int  id { get; set; }
        public string Name { get; set; }
        public DateTime Date1 { get; set; }
        public int No_of_books_published{ get; set; }
        public string Royalty { get; set; }

    }
}
