﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly RecruitCatChen4co.Data.RecruitCatChen4coContext _context;

        public IndexModel(RecruitCatChen4co.Data.RecruitCatChen4coContext context)
        {
            _context = context;
        }

        public IList<JobTitle> JobTitle { get;set; } = default!;

        public async Task OnGetAsync()
        {
            JobTitle = await _context.JobTitle.ToListAsync();
        }
    }
}
