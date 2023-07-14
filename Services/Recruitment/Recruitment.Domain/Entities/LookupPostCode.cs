namespace Recruitment.Domain.Entities;

public partial class PostCode
{
    public int PostCodeId { get; set; }
    public string PostCodeName { get; set; } = null!;
    public int CountryId { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
    
}
