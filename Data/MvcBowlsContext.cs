using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcBowls.Models;

namespace MvcBowls.Data
{
    public class MvcBowlsContext : DbContext
    {
        public MvcBowlsContext (DbContextOptions<MvcBowlsContext> options)
            : base(options)
        {
        }

        public DbSet<MvcBowls.Models.Bowl> Bowl { get; set; }
    }
}
