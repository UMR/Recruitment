namespace Recruitment.Application.Features.ManageRole;

public class RoleListDto
{
    public int RoleId { get; set; }
    public string RoleName { get; set; } = null!;
    public int? Rank { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
