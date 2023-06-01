namespace Recruitment.IdentityServer.Services
{
    public class ResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        private readonly ILogger<ResourceOwnerPasswordValidator> _logger;
        private readonly IUserService _userService;

        public ResourceOwnerPasswordValidator(ILogger<ResourceOwnerPasswordValidator> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }
        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            try
            {
                int userId = await _userService.GetUserId(context.UserName, context.Password);

                if (userId > 0)
                {
                    context.Result = new GrantValidationResult(userId.ToString(), OidcConstants.AuthenticationMethods.Password);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }
        }

    }
}
