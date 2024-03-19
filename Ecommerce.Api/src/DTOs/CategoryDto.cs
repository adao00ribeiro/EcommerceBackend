using Ecommerce.Api.src.Entities;

namespace Ecommerce.Api.src.DTOs;
public record CategoryDto
{
    public string Name { get; set; }
    public string Slug { get; set; }

    internal static CategoryDto ConvertToDto(Category? category)
    {
        if (category is null)
        {
            return new CategoryDto();
        }
        return new CategoryDto()
        {
            Name = category.Name.ToLower(),
            Slug = category.Slug.ToLower()
        };
    }

    internal static Category ConvertToEntity(CategoryDto dto)
    {
        return new Category(dto.Name.ToLower(), dto.Slug.ToLower());
    }
}
