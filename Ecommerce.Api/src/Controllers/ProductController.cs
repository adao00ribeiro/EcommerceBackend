using System.Net;

using Ecommerce.Api.src.Entities;
using Ecommerce.Api.src.Exceptions;
using Ecommerce.Api.src.Interfaces.Repositories;
using Ecommerce.Api.src.Controllers.Shared;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Api.src.DTOs;

namespace Ecommerce.Api.src.Controllers;

[ApiVersion("1.0")]
public class ProductController(IProductRepository _productRepository) : ApiControllerBase
{
  private readonly IProductRepository productRepository = _productRepository;

  [HttpGet("all")]
  public async Task<ActionResult<IEnumerable<ProductDto>>> GetAll()
  {
    return Ok(await this.productRepository.GetAllAsync());
  }

  [HttpPost()]
  public async Task<ActionResult<CategoryDto>> Create(ProductDto dto)
  {
    return Ok(await this.productRepository.AddAsync(ProductDto.ConvertToEntity(dto)));
  }

  [HttpGet("id/{id}")]
  public async Task<ActionResult<CategoryDto>> FindOneById(string id)
  {
    return Ok(await this.productRepository.GetByIdAsync(id));
  }

  [HttpPut("id/{id}")]

  public async Task<ActionResult<CategoryDto>> Update(string id, ProductDto dto)
  {
    var cate = ProductDto.ConvertToEntity(dto);
    cate.Id = id;
    await this.productRepository.UpdateAsync(cate);
    return Ok();
  }
  [HttpDelete("id/{id}")]
  public async Task<ActionResult<ProductDto>> Delete(string id)
  {
    await this.productRepository.RemoveByIdAsync(id);
    return Ok();
  }
}
