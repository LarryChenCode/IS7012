using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AccountHolderList.Data;
using AccountHolderList.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AccountHolderList.Pages.BankAccounts
{
    public class DetailsModel : PageModel
    {
        private readonly AccountHolderList.Data.AccountHolderListContext _context;

        public DetailsModel(AccountHolderList.Data.AccountHolderListContext context)
        {
            _context = context;
        }

        public BankAccount BankAccount { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankaccount = await _context.BankAccount
                .Include(b => b.AccountHolder).FirstOrDefaultAsync(m => m.Id == id);
            if (bankaccount == null)
            {
                return NotFound();
            }
            else
            {
                BankAccount = bankaccount;
            }
            return Page();
        }
    }
}
