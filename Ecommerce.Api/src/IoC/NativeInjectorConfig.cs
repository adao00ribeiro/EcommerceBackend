
using Ecommerce.Api.src.Interfaces.Services;
using Ecommerce.Api.src.Context;
using Ecommerce.Api.src.Interfaces.Repositories;
using Ecommerce.Api.src.Repositories;
using Ecommerce.Api.src.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace Ecommerce.Api.src.IoC;

public static class NativeInjectorConfig
{
    public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DataContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("Database"))
        );
        services.AddDbContext<IdentityDataContext>(options =>
          options.UseSqlite(configuration.GetConnectionString("Database"))
      );
        services.AddDefaultIdentity<IdentityUser>()
                          .AddRoles<IdentityRole>()
                          .AddEntityFrameworkStores<IdentityDataContext>()
                          .AddDefaultTokenProviders();

        services.AddScoped<ICartRepository, CartRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IIdentityService, IdentityService>();
    }
}
