namespace Recruitment.Application.Features.ApplicantType;

public class ApplicantTypeListDto
{
    public long ApplicantTypeId { get; set; }
    public string Name { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
