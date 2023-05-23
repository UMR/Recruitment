namespace Recruitment.Application.Features.Agencies.Dtos
{
    public class CreateAgencyDto
    {        
        public string AgencyName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        
    }
}
