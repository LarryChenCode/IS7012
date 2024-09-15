namespace RecruitCatChen4co.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string PositionName { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public DateOnly? StartDate { get; set; }
        public string Location { get; set; }
        public String ContactName { get; set; }
        public String ContactPhoneNumber { get; set; }
        public List<Candidate>? Candidates { get; set; }
        public Industry? Industry { get; set; }
        public int? IndustryId { get; set; }
    }
}
