public class BookCartItem
{
    public Guid BookCartItemId { get; set; }
    public Guid BookCartId { get; set; }
    public Guid BookId { get; set; }
    public int Quantity { get; set; } // Số lượng sách

    public BookCart BookCart { get; set; }
    public Book Book { get; set; }
}
