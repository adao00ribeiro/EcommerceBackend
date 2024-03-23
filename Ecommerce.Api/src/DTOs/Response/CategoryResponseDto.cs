using Ecommerce.Api.src.Entities;

namespace Ecommerce.Api.src.DTOs;
public record CategoryResponseDto
{
    public string Name { get; set; }
    public string Slug { get; set; }

    internal static CategoryResponseDto ConvertToDto(Category? category)
    {
        if (category is null)
        {
            return new CategoryResponseDto();
        }
        return new CategoryResponseDto()
        {
            Name = category.Name.ToLower(),
            Slug = category.Slug.ToLower()
        };
    }
  
}
