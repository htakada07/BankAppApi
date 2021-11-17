using Microsoft.EntityFrameworkCore;

namespace BankApi.Models
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Balance> Balances { get; set; }
        public DbSet<PaymentListItem> PaymentListItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Balance>().ToTable("Balance");
            modelBuilder.Entity<PaymentListItem>().ToTable("PaymentListItem");
        }
    }
}