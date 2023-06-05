namespace Recruitment.Infrastructure;

public static class ConfigureServices
{
    public static WebApplicationBuilder ConfigureInfrastructureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IDateTimeService, DateTimeService>();            

        return builder;
    }
}
