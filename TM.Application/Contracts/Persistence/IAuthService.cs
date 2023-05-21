using TM.Application.Features.User.DTOs;

namespace TM.Application.Contracts.Persistence;
public interface IAuthService
{
    Task<AuthResponse> Login(AuthenticationDto authRequest);
}