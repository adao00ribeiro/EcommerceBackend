using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.src.Entities.Shared;


namespace Ecommerce.Api.src.Entities;

public class Product : Entity
{
    public string Name { get;  set; }
    public string Description { get;  set; }
    public double Price { get;  set; }
    public string ImageUrl { get;  set; }
    public string Unit { get;  set; }
    public int Quantity { get;  set; }
    public string Tags { get;  set; }
    public string CategoryId { get;  set; }
    public Category? Category { get;  set; }

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
