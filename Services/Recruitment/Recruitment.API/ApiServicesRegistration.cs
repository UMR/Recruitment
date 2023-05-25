namespace Recruitment.API
{
    public static class ConfigureServices
    {
        public static WebApplicationBuilder AddApiServices(this WebApplicationBuilder builder)
        {
            var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            builder.Host.ConfigureAppConfiguration(webBuilder => {
                webBuilder.AddJsonFile("appsettings.json", false, true);
                webBuilder.AddJsonFile($"appsettings.{enviroment}.json", true, true);
                webBuilder.AddEnvironmentVariables();
            });

            builder.ConfigureIdentityServerServices();
            builder.Services.ConfigurePersistenceServices();
            builder.ConfigureApplicationServices();

            builder.Services.AddControllers(config =>
            {
                config.Filters.Add(new AuthorizeFilter(new AuthorizationPolicyBuilder().
                    RequireAuthenticatedUser().
                    RequireClaim(builder.Configuration["IdentityServer:ClaimType"], builder.Configuration["IdentityServer:ClaimValue"]).Build()));
            });

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c => {
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            });

            return builder;
        }
    }
}
