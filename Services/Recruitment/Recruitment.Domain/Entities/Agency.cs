namespace Recruitment.Domain.Entities
{
    public class Agency
    {
        public long AgencyId { get; set; }
        public string? AgencyName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        
    }
}
