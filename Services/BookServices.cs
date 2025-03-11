public interface IBookService
{
    IEnumerable<Book> GetAllBooks();
    Book GetBookById(Guid bookId);
}

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public IEnumerable<Book> GetAllBooks()
    {
        return _bookRepository.GetAllBooks();
    }

    public Book GetBookById(Guid bookId)
    {
        return _bookRepository.GetBookById(bookId);
    }
}
