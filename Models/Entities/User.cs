public class User
{
    public Guid UserId { get; set; }
    public string FullName { get; set; }
    public string IdentityNumber { get; set; } // Số căn cước công dân
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation Property
    public LibraryCard LibraryCard { get; set; }
    public List<LibraryTransaction> LibraryTransactions { get; set; } = new();
    public List<PaymentTransaction> PaymentTransactions { get; set; } = new();
}
