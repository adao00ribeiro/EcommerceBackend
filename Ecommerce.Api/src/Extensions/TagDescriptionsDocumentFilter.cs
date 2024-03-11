using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Ecommerce.Api.src.Extensions;

public class TagDescriptionsDocumentFilter : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        swaggerDoc.Tags = new List<OpenApiTag> {
             new OpenApiTag { Name = "Identity", Description = "Register login" },
            new OpenApiTag { Name = "Product", Description = "Browse/manage the product catalog" },
            new OpenApiTag { Name = "Category", Description = "Categorys" }
        };
    }
}
