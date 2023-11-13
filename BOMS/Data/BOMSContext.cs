using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BOMS.Models;

namespace BOMS.Data
{
    public class BOMSContext : DbContext
    {
        public BOMSContext (DbContextOptions<BOMSContext> options)
            : base(options)
        {
        }

        public DbSet<BOMS.Models.Order> Order { get; set; } = default!;
    }
}
