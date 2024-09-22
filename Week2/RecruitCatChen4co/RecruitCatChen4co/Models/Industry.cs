using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatChen4co.Models
{
    public class Industry
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Industry Name is required.")]
        [Display(Name = "Industry Name")]
        [StringLength(20, ErrorMessage = "Industry Name cannot be longer than 20 characters.")]
        public string IndustryName { get; set; }

        [Display(Name = "Description")]
        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        public string? Description { get; set; }

        public List<Company>? Companies { get; set; }
        public List<Candidate>? Candidates { get; set; }
    }
}
