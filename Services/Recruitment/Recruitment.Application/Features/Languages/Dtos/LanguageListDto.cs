namespace Recruitment.Application.Features.Languages;

public class LanguageListDto
{
    public int LanguageId { get; set; }
    public string Name { get; set; } = null!;
    public int? CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
