using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Recruitment.Application
{
    public static class ApplicationServicesRegistration
    {
        public static WebApplicationBuilder ConfigureApplicationServices(this WebApplicationBuilder builder)
        {
            builder.AddSerilogFromAppSettings();
            builder.Services.AddAutoMapper(typeof(MappingProfile));
            builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
            builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            builder.Services.AddFluentValidationAutoValidation();
            builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehaviour<,>));
            builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            builder.Services.AddTransient<IAgencyService, AgencyService>();

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
}
