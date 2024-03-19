using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.src.Entities;

namespace Ecommerce.Api.src.DTOs;

public record ProductDto
{
    public string Id { get;  set; }
    public string Name { get;  set; }
    public string Description { get;  set; }
    public double Price { get;  set; }
    public string ImageUrl { get;  set; }
    public string Unit { get;  set; }
    public int Quantity { get;  set; }
    public string Tags { get;  set; }
    public string CategoryId { get;  set; }
    public Category? Category { get;  set; }
    internal static ProductDto ConvertToDto(Product product)
    {
        return new ProductDto(){
            Id = product.Id,
        Name = product.Name,
        Description = product.Description,
        Price = product.Price,
        ImageUrl = product.ImageUrl,
        Unit = product.Unit,
        Quantity = product.Quantity,
        Tags = product.Tags,
        CategoryId = product.CategoryId,
        Category = product.Category,
        };
    }

    internal static Product ConvertToEntity(ProductDto product)
    {
        return new Product(
            product.Id,
            product.Name,
            product.Description,
            product.Price,
            product.ImageUrl,
            product.Unit,
            product.Quantity,
            product.Tags,
            product.CategoryId
        );
    }
}
