using FluentValidation;
using Minecraft.API.Models.DTOs;

namespace Minecraft.API.Validators;

public class LoginDtoValidator : AbstractValidator<LoginRequestDto>
{
    public LoginDtoValidator()
    {
        RuleFor(x => x.EmailOrUsername)
            .NotEmpty().WithMessage("Email or username is required.");

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Password is required.");
    }
}
