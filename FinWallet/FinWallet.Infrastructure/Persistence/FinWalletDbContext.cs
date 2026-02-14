using FinWallet.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinWallet.Infrastructure.Persistence
{
    public class FinWalletDbContext : DbContext
    {
        public DbSet<AccountEntity> Accounts { get; set; }
        public DbSet<TradeEntity> Trades { get; set; }
        public DbSet<CurrencyEntity> Currencies { get; set; }

        public FinWalletDbContext(DbContextOptions<FinWalletDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountEntity>()
                .HasMany<TradeEntity>(a => a.Trades)
                .WithOne(t => t.Account)
                .HasForeignKey(t => t.AccountId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AccountEntity>()
                .HasMany<AccountEntity>(a => a.SubAccounts)
                .WithOne(a => a.ParentAccount)
                .HasForeignKey(a => a.ParentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CurrencyEntity>()
                .HasMany<AccountEntity>()
                .WithOne(a => a.Currency)
                .HasForeignKey(a => a.CurrencyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
