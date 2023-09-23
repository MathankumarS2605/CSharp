namespace TagHelpers.Models
{
    public class Book
    {
        public int BookID { set; get; }
        public String Title { set; get; }=string.Empty;
        public float Cost { set; get; }
        public String AuthorName { set; get; } = string.Empty;
    }
}
