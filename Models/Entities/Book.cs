public class Book
{
    public Guid BookId { get; set; }
    public string Title { get; set; } // Tên sách
    public string Author { get; set; } // Tác giả
    public int AvailableCopies { get; set; } // Số lượng sách có sẵn
}
