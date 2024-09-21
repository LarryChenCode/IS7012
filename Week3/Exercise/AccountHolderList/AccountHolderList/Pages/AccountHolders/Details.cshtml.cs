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
    public class DetailsModel : PageModel
    {
        private readonly AccountHolderList.Data.AccountHolderListContext _context;

        public DetailsModel(AccountHolderList.Data.AccountHolderListContext context)
        {
            _context = context;
        }

        public AccountHolder AccountHolder { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountholder = await _context.AccountHolder
                .Include(x => x.BankAccounts)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accountholder == null)
            {
                return NotFound();
            }
            else
            {
                AccountHolder = accountholder;
            }
            return Page();
        }
    }
}
