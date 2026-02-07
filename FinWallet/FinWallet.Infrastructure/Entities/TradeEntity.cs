namespace FinWallet.Infrastructure.Entities
{
    public class TradeEntity
    {
        public long Id { get; set; }
        public string AssetName { get; set; }
        public string Type { get; set; } // buy / sell
        public decimal Value { get; set; }
        public decimal? Amount { get; set; }
        public decimal? CurrencyToPln { get; set; }
        public DateTime Date { get; set; }

        // FK
        public long AccountId { get; set; } // Account FK

        public AccountEntity Account { get; set; } = null!;
    }
}
