﻿namespace Recruitment.Application;

public static class ConfigureServices
{
    public static WebApplicationBuilder ConfigurePersistenceServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<IDapperContext, DapperContext>();
        builder.Services.AddScoped<IMenuRepository, MenuRepository>();
        builder.Services.AddScoped<IAgencyRepository, AgencyRepository>();
        builder.Services.AddScoped<IEmailTypeRepository, EmailTypeRepository>();
        builder.Services.AddScoped<IInstitutionTypeRepository, InstitutionTypeRepository>();
        builder.Services.AddScoped<IUserRepository, UserRepository>();
        builder.Services.AddScoped<IPositionLicenseRequirementRepository, PositionLicenseRequirementRepository>();
        builder.Services.AddScoped<IRecruiterRepository, RecruiterRepository>();

        return builder;
    }
}
