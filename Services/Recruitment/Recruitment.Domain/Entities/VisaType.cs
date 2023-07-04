namespace Recruitment.Domain.Entities;

public partial class VisaTypeEntity
{
    public int Id { get; set; }
    public string? VisaType { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }    
}
