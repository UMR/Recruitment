namespace Recruitment.API.Models;

public class User
{
    public int UserId { get; set; }
    public string LoginId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Telephone { get; set; }
    public bool ODAPermission { get; set; }
    public bool? IsActive { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public int TimeOut { get; set; }
    public Int64? AgencyId { get; set; }

}
