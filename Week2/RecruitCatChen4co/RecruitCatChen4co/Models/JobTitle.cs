using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatChen4co.Models
{
    public class JobTitle
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Job Title is required.")]
        [Display(Name = "Job Title")]
        [StringLength(50, ErrorMessage = "Job Title cannot be longer than 50 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Minimum Salary is required.")]
        [Display(Name = "Minimum Salary")]
        [Range(0, (double)decimal.MaxValue, ErrorMessage = "Minimum Salary must be a positive number.")]
        public decimal MinSalary { get; set; }

        [Required(ErrorMessage = "Maximum Salary is required.")]
        [Display(Name = "Maximum Salary")]
        [Range(0, (double)decimal.MaxValue, ErrorMessage = "Maximum Salary must be a positive number.")]
        public decimal MaxSalary { get; set; }

        [Display(Name = "Work Type")]
        [StringLength(50, ErrorMessage = "Work Type cannot be longer than 50 characters.")]
        public string? WorkType { get; set; }

        [Display(Name = "Job Description")]
        [StringLength(500, ErrorMessage = "Job Description cannot be longer than 500 characters.")]
        public string? JobDescription { get; set; }

        [Display(Name = "Candidates")]
        public List<Candidate>? Candidates { get; set; }
    }
}
