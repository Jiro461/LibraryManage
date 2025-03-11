using Database.Models;

public interface IBookRepository
{
    IEnumerable<Book> GetAllBooks();
    Book GetBookById(Guid bookId);
}

public class BookRepository : IBookRepository
{
    private readonly AppDbContext _context;

    public BookRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Book> GetAllBooks()
    {
        return _context.Books.ToList();
    }

    public Book GetBookById(Guid bookId)
    {
        return _context.Books.FirstOrDefault(b => b.BookId == bookId);
    }
}
