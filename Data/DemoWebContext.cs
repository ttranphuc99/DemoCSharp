using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DemoWeb.Models
{
    public class DemoWebContext : DbContext
    {
        public DemoWebContext (DbContextOptions<DemoWebContext> options)
            : base(options)
        {
        }

        public DbSet<DemoWeb.Models.Project> Project { get; set; }
    }
}
