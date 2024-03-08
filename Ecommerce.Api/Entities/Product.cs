using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Ecommerce.Api.Entities.Shared;

namespace Ecommerce.Api.Entities;

public class Product : Entity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string ImageUrl { get; set; }
    public string Unit { get; set; }
    public int Quantity { get; set; }
    public string Tags { get; set; }
    public string CategoryId { get; set; }
    public Category? Category { get; set; }


}
