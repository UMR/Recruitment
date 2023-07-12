namespace Recruitment.Application.Features.ManageRank;

public class RankListDto
{
    public long RankLookupId { get; set; }
    public int EnumId { get; set; }
    public string Rank { get; set; } = null!;
    public int? CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
