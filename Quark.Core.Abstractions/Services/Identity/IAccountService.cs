using Quark.Core.Abstractions.Requests.Identity;
using Quark.Core.Abstractions.Wrapper;

namespace Quark.Core.Abstractions.Services.Identity;

public interface IAccountService
{
    Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

    Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

    Task<IResult<string>> GetProfilePictureAsync(string userId);

    Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
}