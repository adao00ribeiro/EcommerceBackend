using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.src.Entities;

namespace Ecommerce.Api.src.DTOs;

public record ProductDto
{
    internal static ProductDto ConvertToDto(Product product)
    {
        return new ProductDto();
    }

    internal static Product ConvertToEntity(ProductDto product)
    {
        throw new NotImplementedException();
    }
}
