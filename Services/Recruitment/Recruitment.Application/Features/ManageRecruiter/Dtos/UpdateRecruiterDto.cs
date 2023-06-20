namespace Recruitment.Application.Features.ManageRecruiter;

public class UpdateRecruiterDto
{
    public int Id { get; set; }
    public string Type { get; set; } = null!;
    public bool IsPersonal { get; set; }
    public bool IsOfficial { get; set; }
}
