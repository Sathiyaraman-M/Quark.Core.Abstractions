using Quark.Core.Abstractions.Requests;

namespace Quark.Core.Abstractions.Services;

public interface IUploadService
{
    string UploadAsync(UploadRequest model);
}