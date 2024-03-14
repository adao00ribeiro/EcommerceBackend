using System.Security.Claims;
using Ecommerce.Api.src.Controllers.Shared;
using Ecommerce.Api.src.DTOs.Request;
using Ecommerce.Api.src.DTOs.Response;
using Ecommerce.Api.src.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.src.Controllers;
[ApiVersion("1.0")]
public class IdentityController(IIdentityService _identityService) : ApiControllerBase
{
    private readonly IIdentityService identityService = _identityService;


    [HttpPost("cadastro")]

    public async Task<IActionResult> Cadastrar(RegisterRequest usuarioCadastro)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        var resultado = await _identityService.CadastrarUsuario(usuarioCadastro);
        if (resultado.Sucesso)
            return Ok(resultado);
        else if (resultado.Erros.Count > 0)
        {
            //var problemDetails = new CustomProblemDetails(HttpStatusCode.BadRequest, Request, errors: resultado.Erros);
            return BadRequest(resultado);
        }

        return StatusCode(StatusCodes.Status500InternalServerError);
    }

    [HttpPost("login")]
    public async Task<ActionResult<RegisterResponse>> Login(LoginRequest usuarioLogin)
    {
        if (!ModelState.IsValid)
            return BadRequest();

        var resultado = await _identityService.Login(usuarioLogin);
        if (resultado.Sucesso)
            return Ok(resultado);

        return Unauthorized();
    }
    [Authorize]
    [HttpPost("refresh-login")]
    public async Task<ActionResult<RegisterResponse>> RefreshLogin()
    {
        var identity = HttpContext.User.Identity as ClaimsIdentity;
        var usuarioId = identity?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (usuarioId == null)
            return BadRequest();

        var resultado = await _identityService.LoginSemSenha(usuarioId);
        if (resultado.Sucesso)
            return Ok(resultado);

        return Unauthorized();
    }
}
