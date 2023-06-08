namespace Recruitment.Application.Features.Agencies;

public class UpdateAgencyStatusDto
{
    public long AgencyId { get; set; }

    public bool IsActive { get; set; }
}

