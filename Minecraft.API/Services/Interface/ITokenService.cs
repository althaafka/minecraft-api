using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace Minecraft.API.Services;

public interface ITokenService
{
    string GenerateAccessToken(IdentityUser user);
    string GenerateRefreshToken();
}
