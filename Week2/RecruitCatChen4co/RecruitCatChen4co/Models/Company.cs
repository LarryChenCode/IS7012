using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatChen4co.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Company Name is required.")]
        [Display(Name = "Company Name")]
        [StringLength(50, ErrorMessage = "Company Name cannot be longer than 50 characters.")]
        public string CompanyName { get; set; }

        [Display(Name = "Position Name")]
        [StringLength(50, ErrorMessage = "Position Name cannot be longer than 50 characters.")]
        public string PositionName { get; set; }

        [Required(ErrorMessage = "Minimum Salary is required.")]
        [Display(Name = "Minimum Salary")]
        [Range(0, (double)decimal.MaxValue, ErrorMessage = "Minimum Salary must be a positive number.")]
        public decimal MinSalary { get; set; }

        [Required(ErrorMessage = "Maximum Salary is required.")]
        [Display(Name = "Maximum Salary")]
        [Range(0, (double)decimal.MaxValue, ErrorMessage = "Maximum Salary must be a positive number.")]
        public decimal MaxSalary { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Location")]
        [StringLength(200, ErrorMessage = "Location cannot be longer than 200 characters.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Contact Name is required.")]
        [Display(Name = "Contact Name")]
        [StringLength(50, ErrorMessage = "Contact Name cannot be longer than 50 characters.")]
        public string ContactName { get; set; }

        [Required(ErrorMessage = "Contact Phone Number is required.")]
        [Display(Name = "Contact Phone Number")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone Number must be 10 digits.")]
        public string ContactPhoneNumber { get; set; }

        [Display(Name = "Candidates")]
        public List<Candidate>? Candidates { get; set; }

        [Display(Name = "Industry")]
        public Industry? Industry { get; set; }
        public int? IndustryId { get; set; }
    }
}
