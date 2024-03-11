using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.src.Entities.Shared;

namespace Ecommerce.Api.src.Entities;

public class User : Entity
{
    public string Name;
    public string Email;
}
