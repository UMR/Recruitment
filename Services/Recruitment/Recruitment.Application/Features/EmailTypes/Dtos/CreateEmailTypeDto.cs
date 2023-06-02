namespace Recruitment.Application.Features.EmailTypes;

public class CreateEmailTypeDto
{
    public string Type { get; set; } = null!;
    public bool IsPersonal { get; set; }
    public bool IsOfficial { get; set; }
}
