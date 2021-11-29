using Quark.Core.Abstractions.Responses.Audit;
using Quark.Core.Abstractions.Wrapper;

namespace Quark.Core.Abstractions.Services;

public interface IAuditService
{
    Task<IResult<List<AuditResponse>>> GetCurrentUserTrailsAsync(string userId = "");
}