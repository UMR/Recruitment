namespace Constant
{
    public class AuthConstants
    {
        //LocalHost
        public const string AuthorizationServerURI = "http://localhost:4000";
        public const string ResourceServerURI = "http://localhost:4001";
        public static List<string> WebClientServerURIs = new List<string> { "http://localhost:4002" };
        public const bool IsProductionBuild = false;
        public const int AccessTokenLifetime = 3600;
        public const int SlidingRefreshTokenLifetime = 1296000;

        //umrtest.com
        //public const string AuthorizationServerPath = "http://www.umrtest.com/ApplicantPortalAPIAuthorizationServer";
        //public const string ResourceServerPath = "http://www.umrtest.com/ApplicantPortalAPIResourceServer";
        //public static List<string> WebClientServerPaths = new List<string> { "http://www.umrtest.com", "http://umrtest.com", "http://localhost" };
        //public const bool IsProductionBuild = true;
        //public const int AccessTokenLifetime = 600;
        //public const int SlidingRefreshTokenLifetime = 1800;

        //mechatronicssolutionscorp.com/
        //public const string AuthorizationServerPath = "https://www.mechatronicssolutionscorp.com/ApplicantPortalAPIAuthorizationServer";
        //public const string ResourceServerPath = "https://www.mechatronicssolutionscorp.com/ApplicantPortalAPIResourceServer";
        //public static List<string> WebClientServerPaths = new List<string> { "http://www.mechatronicssolutionscorp.com", "http://mechatronicssolutionscorp.com","https://www.mechatronicssolutionscorp.com", "https://mechatronicssolutionscorp.com", "http://localhost" };
        //public const bool IsProductionBuild = true;
        //public const int AccessTokenLifetime = 600;
        //public const int SlidingRefreshTokenLifetime = 1800;

        ///////////////////// Grandel Rehab //////////////////////
        //public const string AuthorizationServerPath = "http://www.mechatronicssolutionscorp.com/GrandelRehabApplicantPortalAPIAuthorizationServer";
        //public const string ResourceServerPath = "http://www.mechatronicssolutionscorp.com/GrandelRehabApplicantPortalAPIResourceServer";
        //public static List<string> WebClientServerPaths = new List<string> { "http://www.mechatronicssolutionscorp.com", "http://mechatronicssolutionscorp.com", "http://localhost" };
        //public const bool IsProductionBuild = true;
        //public const int AccessTokenLifetime = 600;
        //public const int SlidingRefreshTokenLifetime = 1800;

        //universalmedicalrecord.com
        //public const string AuthorizationServerPath = "https://www.universalmedicalrecord.com/ApplicantPortalAPIAuthorizationServer";
        //public const string ResourceServerPath = "https://www.universalmedicalrecord.com/ApplicantPortalAPIResourceServer";
        //public static List<string> WebClientServerPaths = new List<string> { "http://www.universalmedicalrecord.com", "http://universalmedicalrecord.com", "http://localhost","https://www.universalmedicalrecord.com", "https://universalmedicalrecord.com" };
        //public const bool IsProductionBuild = true;
        //public const int AccessTokenLifetime = 600;
        //public const int SlidingRefreshTokenLifetime = 1800;

        //SPIKE
        //public const string AuthorizationServerPath = "http://172.16.205.67/ApplicantPortalAPIAuthorizationServer";
        //public const string ResourceServerPath = "http://172.16.205.67/ApplicantPortalAPIResourceServer";
        //public static List<string> WebClientServerPaths = new List<string> { "http://172.16.205.67/ApplicantPortalSPA", "http://spike.com", "http://localhost" };
        //public const bool IsProductionBuild = true;
        //public const int AccessTokenLifetime = 600;
        //public const int SlidingRefreshTokenLifetime = 1800;

        //192.168.1.12 New Server
        //public const string AuthorizationServerPath = "http://192.168.1.12/ApplicantPortalAPIAuthorizationServer";
        //public const string ResourceServerPath = "http://192.168.1.12/ApplicantPortalAPIResourceServer";
        //public static List<string> WebClientServerPaths = new List<string> { "http://192.168.1.12", "http://localhost" };
        //public const bool IsProductionBuild = true;
        //public const int AccessTokenLifetime = 600;
        //public const int SlidingRefreshTokenLifetime = 1800;

        //Common        
        public const string CurrentUserClaim = "currentUser";
        public const string TokenPath = "/connect/token";
        public const string UserinfoPath = "/connect/userinfo";
        public const string IntrospectPath = "/connect/introspect";
        public const string RevocationPath = "/connect/revocation";
        public const string RecruitmentScope = "recruitment.scope";
        public const string RecruitmentScopeSecret = "@super#Secret";
        public const string RecruitmentAndroidScopeSecret = "recruitmentAndroidApiSecret";
        public const string WebClientId = "recruitmentweb";
        public const string AndroidClientId = "recruitmentandroid";
        public const string CorsGlobalPolicy = "corsGlobalPolicy";
    }
}