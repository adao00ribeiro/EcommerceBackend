using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.Entities;
using Ecommerce.Api.Interfaces.Repositories.Shared;

namespace Ecommerce.Api.Interfaces.Repositories;

    public interface IProductRepository : IRepositoryBase<Product>
    {
        
    }
