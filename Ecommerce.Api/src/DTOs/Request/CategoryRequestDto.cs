using Ecommerce.Api.src.Entities;

namespace Ecommerce.Api.src.DTOs.Request;
public record CategoryRequestDto
{
    public string Name { get; set; }
    public string Slug { get; set; }

    internal static Category ConvertToEntity(CategoryRequestDto dto)
    {
        return new Category(dto.Name.ToLower(), dto.Slug.ToLower());
    }
}
