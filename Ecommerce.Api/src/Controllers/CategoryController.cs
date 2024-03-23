using Ecommerce.Api.src.Controllers.Shared;
using Ecommerce.Api.src.DTOs;
using Ecommerce.Api.src.DTOs.Request;
using Ecommerce.Api.src.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.src.Controllers;
[ApiVersion("1.0")]
public class CategoryController(ICategoryRepository _categoryRepository) : ApiControllerBase
{
    private readonly ICategoryRepository categoryRepository = _categoryRepository;

    [HttpGet("all")]
    public async Task<ActionResult<IEnumerable<CategoryResponseDto>>> GetAll()
    {
        return Ok(await this.categoryRepository.GetAllAsync());
    }
     [HttpPost()]
    public async Task<ActionResult<string>> Create(CategoryRequestDto dto)
    {
        return Ok( await this.categoryRepository.AddAsync(CategoryRequestDto.ConvertToEntity(dto))); 
    }
 
    [HttpGet("id/{id}")]
    public async Task<ActionResult<CategoryResponseDto>> FindOneById(string id)
    {
       var categorytemp =  await this.categoryRepository.GetByIdAsync(id);
        return Ok(CategoryResponseDto.ConvertToDto(categorytemp)); 
    }
  
    [HttpPut("id/{id}")]

    public async Task<ActionResult<CategoryResponseDto>> Update(string id, CategoryRequestDto dto)
    {   
         var cate = CategoryRequestDto.ConvertToEntity(dto);
         cate.Id = id;
        await this.categoryRepository.UpdateAsync(cate);
        return Ok(); 
    }
    [HttpDelete("id/{id}")]
    public async Task<ActionResult<CategoryResponseDto>> Delete(string id)
    {
        await this.categoryRepository.RemoveByIdAsync(id);
        return Ok(); 
    }
    
}

