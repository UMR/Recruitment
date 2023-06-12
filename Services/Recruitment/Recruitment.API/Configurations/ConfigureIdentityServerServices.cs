using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace Recruitment.API.Configurations;

public static class IdentityServerServicesRegistration
{
    public static WebApplicationBuilder ConfigureIdentityServerServices(this WebApplicationBuilder builder)
    {
        //builder.Services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
        //      .AddIdentityServerAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme, options => {
        //          options.Authority = builder.Configuration["IdentityServer:Authority"];
        //          options.RequireHttpsMetadata = false;
        //          options.ApiName = builder.Configuration["IdentityServer:ApiName"];
        //          options.TokenValidationParameters.ValidIssuers = new[]
        //            {
        //                "http://localhost:5000",
        //                "http://127.0.0.1:5000",
        //            };
        //      });


        builder.Services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
            .AddIdentityServerAuthentication(
                IdentityServerAuthenticationDefaults.AuthenticationScheme,
                options => {
                    options.Authority = builder.Configuration["IdentityServer:Authority"];
                    options.RequireHttpsMetadata = false;

                    // This previously was: options.ApiName = scopeName;
                    options.Audience = builder.Configuration["IdentityServer:ApiName"]; 

                    // Option 1: if you want to turn off issuer validation
                    options.TokenValidationParameters.ValidateIssuer = false;

                    // Option 2: if you want to support multiple issuers
                    //options.TokenValidationParameters.ValidIssuers = new[]
                    //{
                    //    "http://localhost:5000",
                    //    "http://127.0.0.1:5000",
                    //};
                },
                null
            );

        return builder;
    }
}
