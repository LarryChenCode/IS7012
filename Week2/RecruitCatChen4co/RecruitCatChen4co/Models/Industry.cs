namespace RecruitCatChen4co.Models
{
    public class Industry
    {
        public int Id { get; set; }
        public string IndustryName { get; set; }
        public string? Description { get; set; }
        public List<Company>? Companies { get; set; }
        public List<Candidate>? Candidates { get; set; }
    }
}
