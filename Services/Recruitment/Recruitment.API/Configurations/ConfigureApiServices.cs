namespace Recruitment.API.Configurations;

public static class ConfigureServices
{
    public static WebApplicationBuilder ConfigureApiServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddHttpContextAccessor();
        builder.Services.AddSingleton<ICurrentUserService, CurrentUserService>();
        builder.ConfigureEnvironmentServices();
        builder.ConfigureIdentityServerServices();
        builder.ConfigurePersistenceServices();
        builder.ConfigureApplicationServices();
        builder.Services.AddControllers(config =>
        {
            config.Filters.Add<ApiExceptionFilterAttribute>();
            config.Filters.Add(new AuthorizeFilter(new AuthorizationPolicyBuilder().
                RequireAuthenticatedUser().
                RequireClaim(builder.Configuration["IdentityServer:ClaimType"], builder.Configuration["IdentityServer:ClaimValue"]).Build()));
        });
        builder.ConfigureCorsServices();
        builder.ConfigureSwaggerServices();

        return builder;
    }
}
