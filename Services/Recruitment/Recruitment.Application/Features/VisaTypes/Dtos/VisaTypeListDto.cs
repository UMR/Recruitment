namespace Recruitment.Application.Features.VisaTypes;

public class VisaTypeListDto
{
    public int Id { get; set; }

    public string VisaType { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
    
}
