using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.src.Entities;

namespace Ecommerce.Api.src.DTOs.Request;

public class ProductRequestDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string ImageUrl { get; set; }
    public string Unit { get; set; }
    public int Quantity { get; set; }
    public string Tags { get; set; }
    public string CategoryId { get; set; }

    internal static Product ConvertToEntity(ProductRequestDto product)
    {
        return new Product(

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
