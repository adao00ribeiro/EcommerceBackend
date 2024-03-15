using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.src.Entities.Shared;


namespace Ecommerce.Api.src.Entities;

public class Product : Entity
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public double Price { get; private set; }
    public string ImageUrl { get; private set; }
    public string Unit { get; private set; }
    public int Quantity { get; private set; }
    public string Tags { get; private set; }
    public string CategoryId { get; private set; }
    public Category? Category { get; private set; }

    public Product(string name, string description, double price, string imageUrl, string unit, int quantity, string tags, string categoryId)
    {
        Name = name;
        Description = description;
        Price = price;
        ImageUrl = imageUrl;
        Unit = unit;
        Quantity = quantity;
        Tags = tags;
        CategoryId = categoryId;
    }
    public Product(string name, double price, string imageUrl)
    {
        Name = name;
        Price = price;
        ImageUrl = imageUrl;

    }
}
