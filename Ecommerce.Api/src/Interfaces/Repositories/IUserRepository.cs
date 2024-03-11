using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.src.Entities;
using Ecommerce.Api.src.Interfaces.Repositories.Shared;

namespace Ecommerce.Api.src.Interfaces.Repositories;

    public interface IUserRepository: IRepositoryBase<User>
    {
        
    }
