namespace Recruitment.API.Configurations
{
    public static class ConfigureSwaggerServicesRegistration
    {
        public static WebApplicationBuilder ConfigureSwaggerServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(x => {
                x.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "Recruitment Resource Server", Version = "v1" });
                var jwtSecurityScheme = new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the bearer scheme",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "Bearer"
                };
                x.AddSecurityDefinition("Bearer", jwtSecurityScheme);
                x.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    Array.Empty<string>()
                }
                });
            });

            return builder;
        }
    }
}
