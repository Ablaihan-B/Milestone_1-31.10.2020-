using Microsoft.EntityFrameworkCore;
using Milestone_1_31._10._2020_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milestone_1_31._10._2020_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Food> Food { get; set; }
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

    }
}
