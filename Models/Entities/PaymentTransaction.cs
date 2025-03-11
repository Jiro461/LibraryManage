public class PaymentTransaction
{
    public Guid PaymentTransactionId { get; set; }
    public Guid UserId { get; set; }
    public decimal Amount { get; set; } // Số tiền gốc
    public decimal Point { get; set; }
    public DateTime TransactionDate { get; set; } = DateTime.UtcNow;

    public User User { get; set; }
}
