namespace Recruitment.Application.Features.EmailTypes;

public class EmailTypeListDto
{
    public int Id { get; set; }
    public string Type { get; set; } = null!;
    public bool IsPersonal { get; set; }
    public bool IsOfficial { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
