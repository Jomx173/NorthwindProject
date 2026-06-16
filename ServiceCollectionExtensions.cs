using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            // Aquí debes registrar tus servicios de acceso a datos, por ejemplo:
            // services.AddDbContext<YourDbContext>(options => ...);
            // services.AddScoped<IYourRepository, YourRepository>();
            return services;
        }
    }
}