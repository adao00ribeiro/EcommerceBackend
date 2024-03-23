using Ecommerce.Api.src.Interfaces.Repositories;
using Ecommerce.Api.src.Controllers.Shared;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Api.src.DTOs;
using Ecommerce.Api.src.DTOs.Request;

namespace Ecommerce.Api.src.Controllers;

[ApiVersion("1.0")]
public class ProductController(IProductRepository _productRepository) : ApiControllerBase
{
  private readonly IProductRepository productRepository = _productRepository;

  [HttpGet("all")]
  public async Task<ActionResult<IEnumerable<ProductResponseDto>>> GetAll()
  {
    var listProduct = await this.productRepository.GetAllAsync(x => x.Category);
    return Ok(listProduct.Select(x => ProductResponseDto.ConvertToDto(x)));
  }

  [HttpPost()]
  public async Task<ActionResult<ProductResponseDto>> Create(ProductRequestDto dto)
  {
    return Ok(await this.productRepository.AddAsync(ProductRequestDto.ConvertToEntity(dto)));
  }

  [HttpGet("id/{id}")]
  public async Task<ActionResult<ProductResponseDto>> FindOneById(string id)
  {
    return Ok(await this.productRepository.GetByIdAsync(id));
  }

  [HttpPut("id/{id}")]

  public async Task<ActionResult<ProductResponseDto>> Update(string id, ProductRequestDto dto)
  {
    var cate = ProductRequestDto.ConvertToEntity(dto);
    cate.Id = id;
    await this.productRepository.UpdateAsync(cate);
    return Ok();
  }
  [HttpDelete("id/{id}")]
  public async Task<ActionResult<ProductResponseDto>> Delete(string id)
  {
    await this.productRepository.RemoveByIdAsync(id);
    return Ok();
  }
}
