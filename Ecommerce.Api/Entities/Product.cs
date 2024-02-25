using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.Entities.Shared;

namespace Ecommerce.Api.Entities;

    public class Product : Entity
    {
        public string Name { get; set;}
        public double price {get;set;}
        public string imageUrl {get;set;}


    public Product(string name, double price, string imageUrl)
    {
        Name = name;
        this.price = price;
        this.imageUrl = imageUrl;
    }
}
