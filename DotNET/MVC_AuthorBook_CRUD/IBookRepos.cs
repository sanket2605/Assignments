namespace MVC_AuthorBook.Models
{
    public interface IBookRepos
    {
        IEnumerable<Book> GetAllBook();
        Book Add(Book Book);
        Book GetBook(int Id);
        Book Update(Book BookChanges);
        Book Delete(int Id);
    }
}
