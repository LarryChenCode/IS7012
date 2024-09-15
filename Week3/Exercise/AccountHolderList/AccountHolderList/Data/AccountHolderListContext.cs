using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AccountHolderList.Models;

namespace AccountHolderList.Data
{
    public class AccountHolderListContext : DbContext
    {
        public AccountHolderListContext (DbContextOptions<AccountHolderListContext> options)
            : base(options)
        {
        }

        public DbSet<AccountHolderList.Models.AccountHolder> AccountHolder { get; set; } = default!;
        public DbSet<AccountHolderList.Models.BankAccount> BankAccount { get; set; } = default!;
    }
}
