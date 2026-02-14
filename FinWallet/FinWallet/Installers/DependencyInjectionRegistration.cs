using FinWallet.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace FinWallet.Installers
{
    public static class DependencyInjectionRegistration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Db context registration
            services.AddDbContext<FinWalletDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            // Services Registration

            return services;
        }
    }
}
