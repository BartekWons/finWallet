namespace FinWallet.Domain.Entities
{
    public class AccountEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public long? CurrencyId { get; set; }
        public CurrencyEntity? Currency { get; set; }

        public long? ParentId { get; set; } // SubAccount
        public AccountEntity? ParentAccount { get; set; } = null!;

        public ICollection<TradeEntity> Trades { get; set; } = new List<TradeEntity>();
        public ICollection<AccountEntity> SubAccounts { get; set; } = new List<AccountEntity>();
    }

    public enum TradeType
    {
        Buy, 
        Sell
    }
}
