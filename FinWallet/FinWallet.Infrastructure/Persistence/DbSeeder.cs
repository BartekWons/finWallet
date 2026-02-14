using FinWallet.Domain.Entities;

namespace FinWallet.Infrastructure.Persistence
{
    public static class DbSeeder
    {
        public static async Task SeedAsync(FinWalletDbContext context)
        {
            if (context.Currencies.Any())
            {
                return;
            }

            context.Currencies.AddRange(
                new CurrencyEntity { Code = "THB", Name = "Thai baht" },
                new CurrencyEntity { Code = "USD", Name = "US dollar" },
                new CurrencyEntity { Code = "AUD", Name = "Australian dollar" },
                new CurrencyEntity { Code = "HKD", Name = "Hong Kong dollar" },
                new CurrencyEntity { Code = "CAD", Name = "Canadian dollar" },
                new CurrencyEntity { Code = "NZD", Name = "New Zealand dollar" },
                new CurrencyEntity { Code = "SGD", Name = "Singapore dollar" },
                new CurrencyEntity { Code = "EUR", Name = "Euro" },
                new CurrencyEntity { Code = "HUF", Name = "Hungarian forint" },
                new CurrencyEntity { Code = "CHF", Name = "Swiss franc" },
                new CurrencyEntity { Code = "GBP", Name = "British pound" },
                new CurrencyEntity { Code = "UAH", Name = "Ukrainian hryvnia" },
                new CurrencyEntity { Code = "JPY", Name = "Japanese yen" },
                new CurrencyEntity { Code = "CZK", Name = "Czech koruna" },
                new CurrencyEntity { Code = "DKK", Name = "Danish krone" },
                new CurrencyEntity { Code = "ISK", Name = "Icelandic króna" },
                new CurrencyEntity { Code = "NOK", Name = "Norwegian krone" },
                new CurrencyEntity { Code = "SEK", Name = "Swedish krona" },
                new CurrencyEntity { Code = "RON", Name = "Romanian leu" },
                new CurrencyEntity { Code = "TRY", Name = "Turkish lira" },
                new CurrencyEntity { Code = "ILS", Name = "Israeli new shekel" },
                new CurrencyEntity { Code = "CLP", Name = "Chilean peso" },
                new CurrencyEntity { Code = "PHP", Name = "Philippine peso" },
                new CurrencyEntity { Code = "MXN", Name = "Mexican peso" },
                new CurrencyEntity { Code = "ZAR", Name = "South African rand" },
                new CurrencyEntity { Code = "BRL", Name = "Brazilian real" },
                new CurrencyEntity { Code = "MYR", Name = "Malaysian ringgit" },
                new CurrencyEntity { Code = "IDR", Name = "Indonesian rupiah" },
                new CurrencyEntity { Code = "INR", Name = "Indian rupee" },
                new CurrencyEntity { Code = "KRW", Name = "South Korean won" },
                new CurrencyEntity { Code = "CNY", Name = "Chinese yuan" },
                new CurrencyEntity { Code = "XDR", Name = "SDR (Special Drawing Rights)" },
                new CurrencyEntity { Code = "PLN", Name = "Polish złoty" }
            );

            await context.SaveChangesAsync();
        }
    }
}
