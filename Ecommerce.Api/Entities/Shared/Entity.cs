using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Api.Entities.Shared;

    public abstract class Entity
    {
          public int Id { get; protected set; }
    }
