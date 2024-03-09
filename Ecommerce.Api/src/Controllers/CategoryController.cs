using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.src.Controllers.Shared;
using Ecommerce.Api.src.Entities;
using Ecommerce.Api.src.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.src.Controllers;

    public class CategoryController(ICategoryRepository _categoryRepository) : ApiControllerBase
    {
        private readonly ICategoryRepository categoryRepository = _categoryRepository;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetAll()
        {

            return Ok(await this.categoryRepository.GetAllAsync());
        }

    }
