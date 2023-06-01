namespace Recruitment.IdentityServer.Models
{
    public class TokenRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }        

    }
}
