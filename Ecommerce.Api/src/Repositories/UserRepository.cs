using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.src.Context;
using Ecommerce.Api.src.Entities;
using Ecommerce.Api.src.Interfaces.Repositories;
using Ecommerce.Api.src.Repositories.Shared;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Api.src.Repositories;

    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DataContext dataContext) : base(dataContext) { }
     
      

    }
