namespace Recruitment.Application.Features.ManageRank;

public class CreateUpdateUserRankDto
{
    public long UserRankId { get; set; }
    public int UserId { get; set; }
    public long RankLookupId { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public int? EnumId { get; set; }
}
