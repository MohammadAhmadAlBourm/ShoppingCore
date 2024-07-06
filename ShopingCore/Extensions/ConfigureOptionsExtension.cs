using Domain.Options;

namespace ShoppingCore.Extensions;

public static class ConfigureOptionsExtension
{
    public static void RegisterOptions(this IServiceCollection services)
    {
        services.AddOptions<JwtOptions>()
            .BindConfiguration(nameof(JwtOptions))
            .ValidateDataAnnotations()
            .ValidateOnStart();

        services.AddOptions<PasswordHasherOptions>()
            .BindConfiguration(nameof(PasswordHasherOptions))
            .ValidateDataAnnotations()
            .ValidateOnStart();
    }
}