using FluentValidation;
using Minecraft.API.Models.DTOs;

namespace Minecraft.API.Validators;

public class RefreshTokenDtoValidator : AbstractValidator<RefreshTokenRequestDto>
{
    public RefreshTokenDtoValidator()
    {
        RuleFor(x => x.RefreshToken)
            .NotEmpty().WithMessage("Refresh token is required.");
    }
}
