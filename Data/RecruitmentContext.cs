using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Recruitment;

namespace Recruitment.Data
{
    public class RecruitmentContext : DbContext
    {
        public RecruitmentContext (DbContextOptions<RecruitmentContext> options)
            : base(options)
        {
        }
        public DbSet<User> User { get; set; } = default!;
    }
}
