
using Ecommerce.Api.src.Context;
using Ecommerce.Api.src.Interfaces.Repositories;
using Ecommerce.Api.src.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Ecommerce.Api.src.IoC;

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
