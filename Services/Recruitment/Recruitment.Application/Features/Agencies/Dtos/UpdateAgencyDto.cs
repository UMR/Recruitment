namespace Recruitment.Application.Features.Agencies.Dtos
{
    public class UpdateAgencyDto
    {        
        public string AgencyName { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
