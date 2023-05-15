using IdentityServer4.Models;

namespace Recruitment.IdentityServer.Configurations
{
    internal static class Scopes
    {
        public static List<ApiScope> GetScopes()
        {
            var scopes = new List<ApiScope>
            {
                new ApiScope
                {
                    Name ="recruitment.fullaccess",
                    Enabled = true,
                    DisplayName = "Recruitment Web API Resource"
                }
            };            
            return scopes;
        }        
    }

    internal static class Resources
    {
        public static List<ApiResource> GetApiResources()
        {
            var resources = new List<ApiResource>
            {
                new ApiResource
                {
                    Name ="recruitment",
                    Enabled = true,
                    DisplayName = "Recruitment Web API Resource",
                    Scopes = new List<string>
                    {
                         "recruitment.fullaccess"
                    }
                }
            };
            return resources;
        }
    }
}
