﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatChen4co.Data;
using RecruitCatChen4co.Models;

namespace RecruitCatChen4co.Pages.Industries
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatChen4co.Data.RecruitCatChen4coContext _context;

        public DetailsModel(RecruitCatChen4co.Data.RecruitCatChen4coContext context)
        {
            _context = context;
        }

        public Industry Industry { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var industry = await _context.Industry.FirstOrDefaultAsync(m => m.Id == id);
            if (industry == null)
            {
                return NotFound();
            }
            else
            {
                Industry = industry;
            }
            return Page();
        }
    }
}
