namespace Recruitment.Application.Features.Countries;

public class CountryListDto
{
    public int CountryId { get; set; }
    public string CountryName { get; set; } = null!;
    public string Description { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
