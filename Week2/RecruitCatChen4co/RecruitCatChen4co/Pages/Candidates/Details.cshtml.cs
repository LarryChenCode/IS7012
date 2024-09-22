using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatChen4co.Data;
using RecruitCatChen4co.Models;

namespace RecruitCatChen4co.Pages.Candidates
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatChen4co.Data.RecruitCatChen4coContext _context;

        public DetailsModel(RecruitCatChen4co.Data.RecruitCatChen4coContext context)
        {
            _context = context;
        }

        public Candidate Candidate { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidate
                .Include(c => c.JobTitle)
                .Include(c => c.Industry)
                .Include(c => c.Company)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (candidate == null)
            {
                return NotFound();
            }
            else
            {
                Candidate = candidate;
            }
            return Page();
        }
    }
}
