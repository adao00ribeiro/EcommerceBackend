using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Api.Controllers.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ecommerce.Api.Controllers;



public class ProductController : ApiControllerBase
{

    [HttpGet]
    public string GetAll()
    {
        return "OLA MUNDO";
    }

}
