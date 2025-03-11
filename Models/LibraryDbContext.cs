using Microsoft.EntityFrameworkCore;

namespace Database.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<LibraryCard> LibraryCards { get; set; }
        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }
        public DbSet<LibraryTransaction> LibraryTransactions { get; set; }
        public DbSet<BookCart> BookCarts { get; set; }
        public DbSet<BookCartItem> BookCartItems { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .HasOne(u => u.LibraryCard)
                .WithOne(l => l.User)
                .HasForeignKey<LibraryCard>(l => l.UserId);

            modelBuilder
                .Entity<LibraryTransaction>()
                .HasOne(lt => lt.User)
                .WithMany(u => u.LibraryTransactions)
                .HasForeignKey(lt => lt.UserId);

            modelBuilder
                .Entity<PaymentTransaction>()
                .HasOne(pt => pt.User)
                .WithMany(u => u.PaymentTransactions)
                .HasForeignKey(pt => pt.UserId);

            modelBuilder
                .Entity<BookCart>()
                .HasOne(bc => bc.User)
                .WithMany()
                .HasForeignKey(bc => bc.UserId);

            modelBuilder
                .Entity<BookCartItem>()
                .HasOne(bci => bci.BookCart)
                .WithMany(bc => bc.BookCartItems)
                .HasForeignKey(bci => bci.BookCartId);

            modelBuilder
                .Entity<BookCartItem>()
                .HasOne(bci => bci.Book)
                .WithMany()
                .HasForeignKey(bci => bci.BookId);
        }
    }
}
