namespace Recruitment.API.Configurations
{
    public static class ConfigureServices
    {
        public static WebApplicationBuilder ConfigureApiServices(this WebApplicationBuilder builder)
        {
            var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            builder.Host.ConfigureAppConfiguration(webBuilder => {
                webBuilder.AddJsonFile("appsettings.json", false, true);
                webBuilder.AddJsonFile($"appsettings.{enviroment}.json", true, true);
                webBuilder.AddEnvironmentVariables();
            });

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

            builder.Services.AddCors(o =>
            {
                o.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            builder.ConfigureSwaggerServices();

            return builder;
        }
    }
}
