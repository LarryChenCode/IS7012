using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatChen4co.Data;
using RecruitCatChen4co.Models;

namespace RecruitCatChen4co.Pages.JobTitles
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatChen4co.Data.RecruitCatChen4coContext _context;

        public DeleteModel(RecruitCatChen4co.Data.RecruitCatChen4coContext context)
        {
            _context = context;
        }

        [BindProperty]
        public JobTitle JobTitle { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobtitle = await _context.JobTitle.FirstOrDefaultAsync(m => m.Id == id);

            if (jobtitle == null)
            {
                return NotFound();
            }
            else
            {
                JobTitle = jobtitle;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobtitle = await _context.JobTitle.FindAsync(id);
            if (jobtitle != null)
            {
                JobTitle = jobtitle;
                _context.JobTitle.Remove(JobTitle);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
