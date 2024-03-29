﻿namespace Recruitment.Application;

public static class ConfigureServices
{
    public static WebApplicationBuilder ConfigurePersistenceServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<IDapperContext, DapperContext>();
        builder.Services.AddSingleton<IDataAccessBase, DataAccessBase>();
        builder.Services.AddScoped<IMenuRepository, MenuRepository>();
        builder.Services.AddScoped<IAgencyRepository, AgencyRepository>();
        builder.Services.AddScoped<IEmailTypeRepository, EmailTypeRepository>();
        builder.Services.AddScoped<IRoleRepository, RoleRepository>();
        builder.Services.AddScoped<IRankRepository, RankRepository>();
        builder.Services.AddScoped<IInstitutionTypeRepository, InstitutionTypeRepository>();
        builder.Services.AddScoped<IUserRepository, UserRepository>();
        builder.Services.AddScoped<IPositionLicenseRequirementRepository, PositionLicenseRequirementRepository>();
        builder.Services.AddScoped<IRecruiterRepository, RecruiterRepository>();
        builder.Services.AddScoped<ISpecialWordRepository, SpecialWordRepository>();
        builder.Services.AddScoped<IUpperCaseWordRepository, UpperCaseWordRepository>();
        builder.Services.AddScoped<ILowerCaseWordRepository, LowerCaseWordRepository>();
        builder.Services.AddScoped<IApplicantTypeRepository, ApplicantTypeRepository>();
        builder.Services.AddScoped<IVisaTypeRepository, VisaTypeRepository>();
        builder.Services.AddScoped<ILanguageRepository, LanguageRepository>();
        builder.Services.AddScoped<ICountryRepository, CountryRepository>();
        builder.Services.AddScoped<IPostCodeRepository, PostCodeRepository>();

        return builder;
    }
}
