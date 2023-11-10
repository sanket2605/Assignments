using Microsoft.EntityFrameworkCore;
using System;

namespace MVC_AuthorBook.Models
{
    public class BookContext : DbContext
    {
        //public BookContext() { }


        public BookContext(DbContextOptions<BookContext> options)
        : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }


    }
}
