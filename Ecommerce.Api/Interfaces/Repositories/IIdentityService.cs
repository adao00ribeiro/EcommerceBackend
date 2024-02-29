using Ecommerce.Api.DTOs.Request;
using Ecommerce.Api.DTOs.Response;

namespace Ecommerce.Api.Application.Interfaces.Services;

public interface IIdentityService
{
  Task<RegisterResponse> CadastrarUsuario(RegisterRequest usuarioCadastro);
  Task<LoginResponse> Login(LoginRequest usuarioLogin);
  Task<LoginResponse> LoginSemSenha(string usuarioId);
}
