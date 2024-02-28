
using Ecommerce.Api.Context;
using Ecommerce.Api.Interfaces.Repositories;
using Ecommerce.Api.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Ecommerce.Api.IoC;

public static class NativeInjectorConfig
{
    public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DataContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("Database"))
        );
        services.AddScoped<IProductRepository, ProductRepository>();
    }
}
