namespace Recruitment.Application.Features.Menus;

public class MenuListDto
{
    public int MenuId { get; set; }

    public string Culture { get; set; }

    public string Title { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
