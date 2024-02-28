using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Ecommerce.Api.PolicyRequirements;

public class HorarioComercialRequirement : IAuthorizationRequirement
{
    public HorarioComercialRequirement() { }
}
