using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Api.Extensions;

public static class ApiVersioningSetup
{
    public static void AddVersioning(this IServiceCollection services)
    {
        services.AddApiVersioning(options =>
   {
       options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
       options.AssumeDefaultVersionWhenUnspecified = true;
       options.ReportApiVersions = true;
   });
        services.AddVersionedApiExplorer(options =>
        {
            options.GroupNameFormat = "'v'VVV";
            options.SubstituteApiVersionInUrl = true;
        });


    }
}
