namespace Recruitment.Application;

public static class ConfigureServices
{
    public static WebApplicationBuilder ConfigureApplicationServices(this WebApplicationBuilder builder)
    {
        builder.AddSerilogFromAppSettings();
        builder.Services.AddAutoMapper(typeof(MappingProfile));
        builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
        builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        //builder.Services.AddFluentValidationAutoValidation();
        builder.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingBehaviour<,>));
        builder.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        builder.Services.AddScoped<IAgencyService, AgencyService>();
        builder.Services.AddScoped<IEmailTypeService, EmailTypeService>();
        builder.Services.AddScoped<IInstitutionTypeService, InstitutionTypeService>();
        builder.Services.AddScoped<IMenuService, MenuService>();
        builder.Services.AddScoped<IPositionLicenseRequirementService, PositionLicenseRequirementService>();
        builder.Services.AddScoped<IRecruiterService, RecruiterService>();
        builder.Services.AddScoped<ISpecialWordService, SpecailWordService>();
        builder.Services.AddScoped<IUpperCaseWordService, UpperCaseWordService>();
        builder.Services.AddScoped<ILowerCaseWordService, LowerCaseWordService>();
        builder.Services.AddScoped<IApplicantTypeService, ApplicantTypeService>();

        return builder;
    }

    private static WebApplicationBuilder AddSerilogFromSerilogConfig(this WebApplicationBuilder builder)
    {
        var logger = new LoggerConfiguration()
           .ReadFrom.Configuration(new ConfigurationBuilder()
           .AddJsonFile("serilog.development.config.json")
           .Build())
           .Enrich.FromLogContext()
           .CreateLogger();
        builder.Logging.ClearProviders();
        builder.Logging.AddConsole();
        builder.Logging.AddSerilog(logger);

        return builder;
    }

    private static WebApplicationBuilder AddSerilogFromAppSettings(this WebApplicationBuilder builder)
    {
        var logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Configuration)
                .Enrich.FromLogContext()
                .CreateLogger();
        builder.Logging.ClearProviders();
        builder.Logging.AddConsole();
        builder.Logging.AddSerilog(logger);

        return builder;
    }
}
