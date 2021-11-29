using FluentValidation;
using Quark.Core.Abstractions.Requests.Identity;

namespace Quark.Core.Abstractions.Validators.Requests.Identity;

public class UpdateProfileRequestValidator : AbstractValidator<UpdateProfileRequest>
{
    public UpdateProfileRequestValidator()
    {
        RuleFor(request => request.UserName).Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "User Name is required");
        RuleFor(request => request.FullName).Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Full Name is required");
    }
}