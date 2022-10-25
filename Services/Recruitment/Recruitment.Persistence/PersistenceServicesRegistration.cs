using Microsoft.Extensions.DependencyInjection;
using Recruitment.Application.Contracts.Persistence;
using Recruitment.Persistence.Common;
using Recruitment.Persistence.Repositories;

namespace Recruitment.Application
{
    public static class PersistenceServicesRegistration
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
