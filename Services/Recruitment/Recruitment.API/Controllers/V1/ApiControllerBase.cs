using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ResourceServer.Models;

namespace Recruitment.API.Controllers.V1
{
    public class ApiControllerBase : ControllerBase
    {
        private ISender _mediator = null!;

        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();

        protected User CurrentUser {
            get {
                User currentUser = null;
                var currentUserClaim = User.FindFirst("user");

                if (currentUserClaim != null && !string.IsNullOrEmpty(currentUserClaim.Value))
                {
                    currentUser = JsonConvert.DeserializeObject<User>(currentUserClaim.Value);
                }

                return currentUser;
            }
        }
    }
}
