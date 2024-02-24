using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Api.Entities
{
    public class Product
    {
        public string Id {get;set;}
        public string Name { get; set;}
        public double price {get;set;}
        public string imageUrl {get;set;}
    }
}