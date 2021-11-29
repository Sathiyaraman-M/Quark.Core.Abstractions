using Quark.Core.Abstractions.Requests.Identity;
using Quark.Core.Abstractions.Responses.Identity;
using Quark.Core.Abstractions.Wrapper;

namespace Quark.Core.Abstractions.Services.Identity;

public interface ITokenService
{
    Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

    Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
}