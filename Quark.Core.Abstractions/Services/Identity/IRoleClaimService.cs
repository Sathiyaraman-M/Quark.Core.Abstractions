using Quark.Core.Abstractions.Requests.Identity;
using Quark.Core.Abstractions.Responses.Identity;
using Quark.Core.Abstractions.Wrapper;

namespace Quark.Core.Abstractions.Services.Identity;

public interface IRoleClaimService
{
    Task<Result<List<RoleClaimResponse>>> GetAllAsync();

    Task<int> GetCountAsync();

    Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

    Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

    Task<Result<string>> SaveAsync(RoleClaimRequest request);

    Task<Result<string>> DeleteAsync(int id);
}