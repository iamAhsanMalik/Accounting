using Application.Configurations.MailJet;
using Application.Configurations.SMTP;
using Application.Contracts.Identity;
using Infrastructure.Files;
using Infrastructure.Services.Communication.Email;
using Infrastructure.Services.Communication.SMS;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<MailJetConfig>(configuration.GetSection("MailJet"));
        services.Configure<SMTPConfig>(configuration.GetSection("SMTPServers"));

        #region Infrastructure
        services.AddScoped<IEmailService, EmailService>();
        services.AddScoped<ISmsService, SMSServices>();
        services.AddScoped<IFileHelpers, FileHelpers>();
        #endregion
        return services;
    }
}