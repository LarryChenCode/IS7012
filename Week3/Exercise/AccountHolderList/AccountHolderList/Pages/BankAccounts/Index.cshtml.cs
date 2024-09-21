using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AccountHolderList.Data;
using AccountHolderList.Models;

namespace AccountHolderList.Pages.BankAccounts
{
    public class IndexModel : PageModel
    {
        private readonly AccountHolderList.Data.AccountHolderListContext _context;

        public IndexModel(AccountHolderList.Data.AccountHolderListContext context)
        {
            _context = context;
        }

        public IList<BankAccount> BankAccount { get;set; } = default!;

        public async Task OnGetAsync()
        {
            BankAccount = await _context.BankAccount
                .Include(b => b.AccountHolder).ToListAsync();
        }
    }
}
