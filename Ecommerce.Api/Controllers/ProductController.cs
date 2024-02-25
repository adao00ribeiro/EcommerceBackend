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
      new Product ( "Camiseta básica",  19.99,  "https://m.media-amazon.com/images/I/417S18ZulVL._AC_SX679_.jpg" ),
      new Product ( "Calça jeans",  39.99,  "https://m.media-amazon.com/images/I/417S18ZulVL._AC_SX679_.jpg" ),
      new Product ( "Tênis esportivo",  59.99,  "https://m.media-amazon.com/images/I/417S18ZulVL._AC_SX679_.jpg" ),
      new Product ( "Relógio de pulso",  79.99,  "https://m.media-amazon.com/images/I/417S18ZulVL._AC_SX679_.jpg" ),
      new Product ( "Bolsa de couro",  99.99,  "https://m.media-amazon.com/images/I/417S18ZulVL._AC_SX679_.jpg" ),
      new Product ( "Óculos de sol",  29.99,  "https://m.media-amazon.com/images/I/417S18ZulVL._AC_SX679_.jpg" )

   ];
        return Ok(products);
    }

}
