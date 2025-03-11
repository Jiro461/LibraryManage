public class LibraryCard
{
    public Guid LibraryCardId { get; set; }
    public Guid UserId { get; set; }
    public decimal Balance { get; set; } = 0; // Số dư thẻ
    public decimal Point { get; set; } = 0;

    public User User { get; set; } // Navigation Property
}
