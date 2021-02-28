using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AkwadTask.Models;

namespace AkwadTask.Data
{
    public class AkwadTaskContext : DbContext
    {
        public AkwadTaskContext (DbContextOptions<AkwadTaskContext> options)
            : base(options)
        {
        }

        public DbSet<AkwadTask.Models.Department> Department { get; set; }

        public DbSet<AkwadTask.Models.Job> Job { get; set; }

        public DbSet<AkwadTask.Models.Employee> Employee { get; set; }
    }
}
