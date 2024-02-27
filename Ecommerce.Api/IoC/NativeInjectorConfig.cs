
using Microsoft.AspNetCore.Identity;


namespace Ecommerce.Api.IoC;

    public static class NativeInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            /*
            services.AddDbContext<DataContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("Database"))
            );
*/
        }
    }
