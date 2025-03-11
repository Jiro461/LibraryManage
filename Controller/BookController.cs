using Microsoft.AspNetCore.Mvc;

[Route("api/books")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    // Lấy tất cả sách
    [HttpGet("all")]
    public IActionResult GetAllBooks()
    {
        var books = _bookService.GetAllBooks();
        return Ok(books);
    }

    // Lấy sách theo ID
    [HttpGet("{id}")]
    public IActionResult GetBookById(Guid id)
    {
        var book = _bookService.GetBookById(id);
        if (book == null)
        {
            return NotFound("Không tìm thấy sách.");
        }
        return Ok(book);
    }
}
