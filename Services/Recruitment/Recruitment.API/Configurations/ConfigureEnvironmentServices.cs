namespace Recruitment.API.Configurations
{
    public static class ConfigureEnvironmentServicesRegistration
    {
        public static WebApplicationBuilder ConfigureEnvironmentServices(this WebApplicationBuilder builder)
        {
            var enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            builder.Host.ConfigureAppConfiguration(webBuilder => {
                webBuilder.AddJsonFile("appsettings.json", false, true);
                webBuilder.AddJsonFile($"appsettings.{enviroment}.json", true, true);
                webBuilder.AddEnvironmentVariables();
            });

            return builder;
        }
    }    
}
