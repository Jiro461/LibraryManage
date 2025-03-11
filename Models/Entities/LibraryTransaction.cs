public class LibraryTransaction
{
    public Guid LibraryTransactionId { get; set; }
    public Guid UserId { get; set; }
    public decimal Amount { get; set; } // Số tiền gốc
    public decimal DiscountedAmount { get; set; } // Số tiền sau khi áp dụng chiết khấu
    public DateTime TransactionDate { get; set; } = DateTime.UtcNow;
    public DateTime? ReturnDate { get; set; }
    public decimal? Fine { get; set; } // Phí phạt (nếu có)

    public User User { get; set; }
    public List<Book> Books { get; set; } = new();
}
