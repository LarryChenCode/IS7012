using System;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatChen4co.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [Display(Name = "First Name")]
        [StringLength(30, ErrorMessage = "First Name cannot be longer than 30 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [Display(Name = "Last Name")]
        [StringLength(30, ErrorMessage = "Last Name cannot be longer than 30 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Target Salary is required.")]
        [Display(Name = "Target Salary")]
        [Range(0, (double)decimal.MaxValue, ErrorMessage = "Target Salary must be a positive number.")]
        public decimal TargetSalary { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        [Display(Name = "Phone Number")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone Number must be 10 digits.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email Address is required.")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string EmailAddress { get; set; }

        [Display(Name = "LinkedIn Profile")]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        public string? LinkedInProfile { get; set; }

        [Display(Name = "Company")]
        public Company? Company { get; set; }
        public int? CompanyId { get; set; }

        [Display(Name = "Job Title")]
        public JobTitle? JobTitle { get; set; }
        public int? JobTitleId { get; set; }

        [Display(Name = "Industry")]
        public Industry? Industry { get; set; }
        public int? IndustryId { get; set; }
    }
}
