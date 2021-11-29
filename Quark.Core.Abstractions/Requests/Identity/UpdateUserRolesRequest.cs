using Quark.Core.Responses.Identity;

namespace Quark.Core.Abstractions.Requests.Identity;

public class UpdateUserRolesRequest
{
    public string UserId { get; set; }
    public IList<UserRoleModel> UserRoles { get; set; }
}