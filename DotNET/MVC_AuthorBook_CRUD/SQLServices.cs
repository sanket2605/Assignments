using Microsoft.AspNetCore.Mvc;
using System;

namespace MVC_AuthorBook.Models
{
    public class SQLServices : IBookRepos
    {
        private readonly BookContext context;
        public SQLServices(BookContext context)
        {
            this.context = context;
        }
        public IEnumerable<Book> GetAllBook()
        {
            return context.Books;
        }
        public Book Add(Book Book)
        {
            context.Books.Add(Book);
            context.SaveChanges();
            return Book;
        }
        public Book Delete(int Id)
        {
            Book Book = context.Books.Find(Id);
            if (Book != null)
            {
                context.Books.Remove(Book);
                context.SaveChanges();
            }
            return Book;
        }

        public Book GetBook(int Id)
        {
            return context.Books.Find(Id);
        }
        public Book Update(Book BookChanges)
        {
           context.Books.Attach(BookChanges);
            //State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.Update(BookChanges);
            context.SaveChanges();
            return BookChanges;

        }
    }
}
