namespace Recruitment.Application.Features.Menu.Queries
{
    public class AgencyDto
    {
        public long AgencyId { get; set; }
        public string AgencyName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}
