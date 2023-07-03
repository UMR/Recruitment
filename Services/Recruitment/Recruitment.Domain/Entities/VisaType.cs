namespace Recruitment.Domain.Entities;

public partial class VisaType
{
    public int Id { get; set; }
    public string? VisaTypeName { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }    
}
