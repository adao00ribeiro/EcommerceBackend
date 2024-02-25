using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.Context;
using Ecommerce.Api.Entities;
using Ecommerce.Api.Interfaces.Repositories;
using Ecommerce.Api.Repositories.Shared;

namespace Ecommerce.Api.Repositories
{

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}