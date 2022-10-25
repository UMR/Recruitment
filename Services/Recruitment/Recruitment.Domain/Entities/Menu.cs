namespace Recruitment.Domain.Entities
{
    public partial class Menu
    {
        public int MenuId { get; set; }
        public string Culture { get; set; } = null!;
        public string Title { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        
    }
}
