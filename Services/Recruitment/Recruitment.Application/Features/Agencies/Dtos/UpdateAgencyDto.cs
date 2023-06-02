namespace Recruitment.Application.Features.Agencies
{
    public class UpdateAgencyDto
    {        
        public long AgencyId { get; set; }

        public string AgencyName { get; set; }

        public string AgencyAddress { get; set; }

        public string URLPrefix { get; set; }

        public string AgencyEmail { get; set; }

        public string AgencyPhone { get; set; }

        public string AgencyContactPerson { get; set; }

        public string AgencyContactPersonPhone { get; set; }

        public bool? IsActive { get; set; }

        public string AgencyLoginId { get; set; }
    }
}
