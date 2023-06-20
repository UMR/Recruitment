namespace Recruitment.Application.Features.ManageRecruiter;

public class CreateRecruiterDto
{
    public string Type { get; set; } = null!;
    public bool IsPersonal { get; set; }
    public bool IsOfficial { get; set; }
}
