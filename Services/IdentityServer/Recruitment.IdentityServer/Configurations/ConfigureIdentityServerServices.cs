using System.Security.Cryptography.X509Certificates;
using Recruitment.IdentityServer.Extensions;

namespace Recruitment.IdentityServer.Configurations
{
    public static class IdentityServerServicesRegistration
    {
        public static IServiceCollection ConfigureIdentityServerServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddIdentityServer()
            //.AddSigningCredential(new X509Certificate2(Path.Combine("idsrv3test.pfx"), "idsrv3test"))
            //.AddInMemoryApiResources(configuration.GetSection("IdentityServer:ApiResources"))
            //.AddInMemoryApiScopes(configuration.GetSection("IdentityServer:ApiScopes"))
            //.AddInMemoryClients(configuration.GetSection("IdentityServer:Clients"))
            //.AddCustomUserStore();

            services.AddIdentityServer()
            .AddSigningCredential(new X509Certificate2(Path.Combine("idsrv3test.pfx"), "idsrv3test"))
            .AddInMemoryApiResources(Resources.GetApiResources())
            .AddInMemoryApiScopes(Scopes.GetScopes())
            .AddInMemoryClients(Clients.GetClients())
            .AddCustomUserStore();

            return services;
        }
    }
}
