namespace Recruitment.API.Configurations
{
    public static class ConfigureCorsServicesRegistration
    {
        public static WebApplicationBuilder ConfigureCorsServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddCors(o => {
                o.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            return builder;
        }
    }
}
