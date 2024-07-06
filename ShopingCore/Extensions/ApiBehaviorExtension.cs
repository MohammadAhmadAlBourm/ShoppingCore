using Microsoft.AspNetCore.Mvc;

namespace ShoppingCore.Extensions;

public static class ApiBehaviorExtension
{
    public static void ConfigureApiBehavior(this IServiceCollection services)
    {
        services.Configure<ApiBehaviorOptions>(options =>
        {
            options.SuppressModelStateInvalidFilter = true;
        });
    }
}