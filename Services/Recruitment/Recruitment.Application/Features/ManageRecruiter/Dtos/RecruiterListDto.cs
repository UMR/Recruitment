namespace Recruitment.Application.Features.ManageRecruiter;

public class RecruiterListDto
{
    public int UserId { get; set; }
    public string LoginId { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Telephone { get; set; }
    public bool Odapermission { get; set; }
    public bool? IsActive { get; set; }
    public long? AgencyId { get; set; }
    public string AgencyName { get; set; }
    public long? ApplicantTypeId { get; set; }
    public long? TimeOut { get; set; }
    public string Name { get; set; }
}
