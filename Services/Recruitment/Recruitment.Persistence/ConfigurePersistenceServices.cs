

namespace Recruitment.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services)
        {
            services.AddTransient<IRecruitmentConnectionFactory, RecruitmentConnectionFactory>();
            services.AddScoped<IMenuRepository, MenuRepository>();
            services.AddScoped<IAgencyRepository, AgencyRepository>();

            return services;
        }
    }
}
