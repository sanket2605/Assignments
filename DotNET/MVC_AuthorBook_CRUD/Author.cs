namespace MVC_AuthorBook.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        public string AuthorName { get; set; }

        public List<Book> Books { get; set; }
    }
}
