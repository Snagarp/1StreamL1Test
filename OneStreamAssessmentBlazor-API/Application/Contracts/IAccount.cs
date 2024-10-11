
using Application.DTOs.Request.Account;
using Application.DTOs.Response.Account;
using Application.DTOs.Response;
namespace Application.Contracts
{
    public interface IAccount
    {
        Task CreateAdmin();
        Task<Response> CreateAccountAsync(CreateAccountDTO model);
        Task<LoginResponse> LoginAccountAsync(LoginDTO model);
        Task<LoginResponse> RefreshTokenAsync(RefreshTokenDTO model);
        Task<Response> CreateRoleAsync(CreateRoleDTO model);
        Task<IEnumerable<GetRoleDTO>> GetRolesAsync();
        Task<IEnumerable<GetUsersWithRolesResponseDTO>> GetUsersWithRolesAsync();
        Task<Response> ChangeUserRoleAsync(ChangeUserRoleRequestDTO model);
    }
}
