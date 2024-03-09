using Ecommerce.Api.src.DTOs.Request;
using Ecommerce.Api.src.DTOs.Response;

namespace Ecommerce.Api.src.Application.Interfaces.Services;

public interface IIdentityService
{
  Task<RegisterResponse> CadastrarUsuario(RegisterRequest usuarioCadastro);
  Task<LoginResponse> Login(LoginRequest usuarioLogin);
  Task<LoginResponse> LoginSemSenha(string usuarioId);
}
