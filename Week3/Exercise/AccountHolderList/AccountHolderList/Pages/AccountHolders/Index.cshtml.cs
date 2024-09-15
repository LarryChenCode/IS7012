using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AccountHolderList.Data;
using AccountHolderList.Models;

namespace AccountHolderList.Pages.AccountHolders
{
    public class IndexModel : PageModel
    {
        private readonly AccountHolderList.Data.AccountHolderListContext _context;

        public IndexModel(AccountHolderList.Data.AccountHolderListContext context)
        {
            _context = context;
        }

        public IList<AccountHolder> AccountHolder { get;set; } = default!;

        public async Task OnGetAsync()
        {
            AccountHolder = await _context.AccountHolder.ToListAsync();
        }
    }
}
