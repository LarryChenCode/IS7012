using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatChen4co.Models;

namespace RecruitCatChen4co.Data
{
    public class RecruitCatChen4coContext : DbContext
    {
        public RecruitCatChen4coContext (DbContextOptions<RecruitCatChen4coContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatChen4co.Models.Candidate> Candidate { get; set; } = default!;
        public DbSet<RecruitCatChen4co.Models.Company> Company { get; set; } = default!;
        public DbSet<RecruitCatChen4co.Models.Industry> Industry { get; set; } = default!;
        public DbSet<RecruitCatChen4co.Models.JobTitle> JobTitle { get; set; } = default!;
    }
}
