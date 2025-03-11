public class BookCart
{
    public Guid BookCartId { get; set; }
    public Guid UserId { get; set; } // Giỏ hàng thuộc về ai
    public List<BookCartItem> BookCartItems { get; set; } = new();

    public User User { get; set; }
}
