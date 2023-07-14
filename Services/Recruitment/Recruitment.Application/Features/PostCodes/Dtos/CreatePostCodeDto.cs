namespace Recruitment.Application.Features.PostCodes;

public class CreatePostCodeDto
{
    public int PostCodeId { get; set; }
    public string PostCode { get; set; } = null!;
    public int CountryId { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }    

}
