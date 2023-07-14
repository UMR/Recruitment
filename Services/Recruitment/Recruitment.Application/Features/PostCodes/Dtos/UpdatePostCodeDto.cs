namespace Recruitment.Application.Features.PostCodes;

public class UpdatePostCodeDto
{
    public int PostCodeId { get; set; }
    public string PostCode { get; set; } = null!;
    public int CountryId { get; set; }   
    public int? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }

}
