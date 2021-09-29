using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BETRAGATEWAY.Models;

namespace BETRAGATEWAY.Data
{
    public class BETRAGATEWAYContext : DbContext
    {
        public BETRAGATEWAYContext (DbContextOptions<BETRAGATEWAYContext> options)
            : base(options)
        {
        }

        public DbSet<BETRAGATEWAY.Models.Gate> Gate { get; set; }
    }
}
