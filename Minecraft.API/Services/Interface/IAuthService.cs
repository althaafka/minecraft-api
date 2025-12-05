using Minecraft.API.Models;
using Minecraft.API.Models.DTOs;

namespace Minecraft.API.Services;
public interface IAuthService
{
    Task<ServiceResult> RegisterAsync(RegisterRequestDto registerDto);
    Task<ServiceResult<TokenResponseDto>> LoginAsync(LoginRequestDto loginDto, string? ipAddress, string? deviceInfo);
    Task<ServiceResult> LogoutAsync(string userId, string refreshToken);
    Task<ServiceResult<TokenResponseDto>> RefreshTokenAsync(string refreshToken, string? ipAddress, string? deviceInfo);
}