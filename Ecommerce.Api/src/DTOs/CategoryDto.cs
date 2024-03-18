using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.src.Entities;

namespace Ecommerce.Api.src.DTOs;
public record CategoryDto
{
    public string Name { get;  set; }
    public string Slug { get;  set; }

    internal static Category ConvertToEntity(CategoryDto dto)
    {
       return new Category(dto.Name.ToLower(),dto.Slug.ToLower());
    }
}
