using System.Net;
using Ecommerce.Api.Controllers.Shared;
using Ecommerce.Api.Entities;
using Ecommerce.Api.Exceptions;
using Ecommerce.Api.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers;

public class ProductController(IProductRepository _productRepository) : ApiControllerBase
{
  private readonly IProductRepository productRepository = _productRepository;

  [HttpGet]
  public async Task<ActionResult<IEnumerable<Product>>> GetAll()
  {
    return Ok(await this.productRepository.GetAllProducts());
  }

}
