using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Danea_Gabriel_Lab2_r.Models;

namespace Danea_Gabriel_Lab2_r.Data
{
    public class Danea_Gabriel_Lab2_rContext : DbContext
    {
        public Danea_Gabriel_Lab2_rContext (DbContextOptions<Danea_Gabriel_Lab2_rContext> options)
            : base(options)
        {
        }

        public DbSet<Danea_Gabriel_Lab2_r.Models.Book> Book { get; set; } = default!;

        public DbSet<Danea_Gabriel_Lab2_r.Models.Publisher> Publisher { get; set; }

        public DbSet<Danea_Gabriel_Lab2_r.Models.Category> Category { get; set; }
    }
}
