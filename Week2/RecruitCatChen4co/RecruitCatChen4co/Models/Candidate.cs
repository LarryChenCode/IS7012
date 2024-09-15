namespace RecruitCatChen4co.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal TargetSalary { get; set; }
        public DateOnly? StartDate { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string? LinkedInProfile { get; set; }
        public Company? Company { get; set; }
        public int? CompanyId { get; set; }
        public JobTitle? JobTitle { get; set; }
        public int? JobTitleId { get; set; }
        public Industry? Industry { get; set; }
        public int? IndustryId { get; set; }
    }
}
