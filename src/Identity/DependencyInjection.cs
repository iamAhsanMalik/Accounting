using Application.Contracts.Identity;
using Identity.Helpers;
using Identity.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Identity;
public static class DependencyInjection
{
    public static IServiceCollection AddIdentityServices(this IServiceCollection services)
    {
        services.AddScoped<IUserInfo, UserInfo>();
        services.AddScoped<IAuthService, AuthService>();
        return services;
    }
}