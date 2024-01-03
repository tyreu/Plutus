using Microsoft.EntityFrameworkCore;
using Plutus.Models;
using Plutus.Models.Transactions;

namespace Plutus.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; } = null!;
        public DbSet<Wallet> Wallets { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;
        public DbSet<Achievement> Achievements { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Plutus.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>();
        }
    }
}