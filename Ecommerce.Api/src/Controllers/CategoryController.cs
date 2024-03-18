using System.Xml;
using Ecommerce.Api.src.Controllers.Shared;
using Ecommerce.Api.src.DTOs;
using Ecommerce.Api.src.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.src.Controllers;
[ApiVersion("1.0")]
public class CategoryController(ICategoryRepository _categoryRepository) : ApiControllerBase
{
    private readonly ICategoryRepository categoryRepository = _categoryRepository;

    [HttpGet("all")]
    public async Task<ActionResult<IEnumerable<CategoryDto>>> GetAll()
    {
        return Ok(await this.categoryRepository.GetAllAsync());
    }
     [HttpPost()]
    public async Task<ActionResult<CategoryDto>> Create(CategoryDto dto)
    {
        return Ok(await this.categoryRepository.AddAsync(CategoryDto.ConvertToEntity(dto))); 
    }
 
    [HttpGet("id/{id}")]
    public async Task<ActionResult<CategoryDto>> FindOneById(string id)
    {
        return Ok(await this.categoryRepository.GetByIdAsync(id)); 
    }
  
    [HttpPut("id/{id}")]

    public async Task<ActionResult<CategoryDto>> Update(string id, CategoryDto dto)
    {   
         var cate =    CategoryDto.ConvertToEntity(dto);
         cate.Id = id;
        await this.categoryRepository.UpdateAsync(cate );
        return Ok(); 
    }
    [HttpDelete("id/{id}")]
    public async Task<ActionResult<CategoryDto>> Delete(string id)
    {
        await this.categoryRepository.RemoveByIdAsync(id);
        return Ok(); 
    }
    
}

