using Microsoft.AspNetCore.Authorization;

namespace Quark.Core.Permissions;

public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
{
    public PermissionAuthorizationHandler() { }

    protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
    {
        if (context.User == null) { await Task.CompletedTask; }
        var permissions = context.User.Claims.Where(x => x.Type == PermissionConstants.PermissionClaimType && x.Value == requirement.Permission && x.Issuer == "LOCAL AUTHORITY");
        if (permissions.Any())
        {
            context.Succeed(requirement);
            await Task.CompletedTask;
        }
    }
}