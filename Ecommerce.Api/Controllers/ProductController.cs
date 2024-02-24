using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.Controllers.Shared;
using Ecommerce.Api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Api.Controllers;



public class ProductController : ApiControllerBase
{

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetAll()
    {
        Product[] products =
        [
      new Product { Id = "1", Name = "Camiseta básica", price = 19.99, imageUrl = "https://m.media-amazon.com/images/I/417S18ZulVL._AC_SX679_.jpg" },
      new Product { Id = "2", Name = "Calça jeans", price = 39.99, imageUrl = "https://m.media-amazon.com/images/I/417S18ZulVL._AC_SX679_.jpg" },
      new Product { Id = "3", Name = "Tênis esportivo", price = 59.99, imageUrl = "https://m.media-amazon.com/images/I/417S18ZulVL._AC_SX679_.jpg" },
      new Product { Id = "4", Name = "Relógio de pulso", price = 79.99, imageUrl = "https://m.media-amazon.com/images/I/417S18ZulVL._AC_SX679_.jpg" },
      new Product { Id = "5", Name = "Bolsa de couro", price = 99.99, imageUrl = "https://m.media-amazon.com/images/I/417S18ZulVL._AC_SX679_.jpg" },
      new Product { Id = "6", Name = "Óculos de sol", price = 29.99, imageUrl = "https://m.media-amazon.com/images/I/417S18ZulVL._AC_SX679_.jpg" }

   ];
        return Ok(products);
    }

}
