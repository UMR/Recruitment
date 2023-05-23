namespace Recruitment.Application.Features.Agencies
{
    public class UpdateAgencyDto
    {        
        public string AgencyName { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
