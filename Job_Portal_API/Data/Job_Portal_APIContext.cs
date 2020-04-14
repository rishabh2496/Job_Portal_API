using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Job_Portal_API.Models;

namespace Job_Portal_API.Data
{
    public class Job_Portal_APIContext : DbContext
    {
        public Job_Portal_APIContext (DbContextOptions<Job_Portal_APIContext> options)
            : base(options)
        {
        }

        public DbSet<Job_Portal_API.Models.JobPortal> JobPortal { get; set; }
    }
}
