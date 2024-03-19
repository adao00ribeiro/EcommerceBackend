using Ecommerce.Api.src.Entities;

namespace Ecommerce.Api.src.DTOs;

public record ProductResponseDto
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string ImageUrl { get; set; }
    public string Unit { get; set; }
    public int Quantity { get; set; }
    public string Tags { get; set; }
    public string CategoryId { get; set; }
    public CategoryResponseDto? Category { get; set; }

    internal static ProductResponseDto ConvertToDto(Product product)
    {
        return new ProductResponseDto()
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            ImageUrl = product.ImageUrl,
            Unit = product.Unit,
            Quantity = product.Quantity,
            Tags = product.Tags,
            CategoryId = product.CategoryId,
            Category = CategoryResponseDto.ConvertToDto(product.Category)
        };
    }


}
