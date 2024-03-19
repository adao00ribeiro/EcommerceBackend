using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.src.Controllers.Shared;

[ApiController]
[Route("api/v{version:apiversion}/[controller]")]
public class ApiControllerBase : ControllerBase
{

}
