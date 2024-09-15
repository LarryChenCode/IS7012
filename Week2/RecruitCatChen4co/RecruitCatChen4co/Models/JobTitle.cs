namespace RecruitCatChen4co.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public string? WorkType { get; set; }
        public string? JobDescription { get; set; }
        public List<Candidate>? Candidates { get; set; }

    }
}
