namespace Recruitment.Application;

public static class ConfigureServices
{
    public static WebApplicationBuilder ConfigurePersistenceServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<IDapperContext, DapperContext>();
        builder.Services.AddScoped<IMenuRepository, MenuRepository>();
        builder.Services.AddScoped<IAgencyRepository, AgencyRepository>();
        builder.Services.AddScoped<IEmailTypeRepository, EmailTypeRepository>();

        return builder;
    }
}
