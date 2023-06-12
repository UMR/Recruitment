namespace Recruitment.Application.Features.Agencies;

public class UpdateAgencyStatusByUserDto
{
    public long AgencyId { get; set; }

    public bool IsActive { get; set; }
    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}

