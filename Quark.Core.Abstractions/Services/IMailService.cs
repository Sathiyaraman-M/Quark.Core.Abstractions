using Quark.Core.Abstractions.Requests;

namespace Quark.Core.Abstractions.Services;

public interface IMailService
{
    Task SendAsync(MailRequest request, string origin);
}