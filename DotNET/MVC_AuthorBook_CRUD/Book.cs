using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_AuthorBook.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public int AuthorId { get; set; }
        public Author Author { get; set;}
    }
}
