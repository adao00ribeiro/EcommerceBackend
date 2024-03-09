using System.Net;

using Ecommerce.Api.src.Entities;
using Ecommerce.Api.src.Exceptions;
using Ecommerce.Api.src.Interfaces.Repositories;
using Ecommerce.Api.src.Controllers.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.src.Controllers;

public class ProductController(IProductRepository _productRepository) : ApiControllerBase
{
  private readonly IProductRepository productRepository = _productRepository;

  [HttpGet]
  public async Task<ActionResult<IEnumerable<Product>>> GetAll()
  {

    return Ok(await this.productRepository.GetAllProducts());
  }

}
