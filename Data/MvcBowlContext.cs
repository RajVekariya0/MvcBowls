using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcBowls.Models;

namespace MvcBowls.Data
{
    public class MvcBowlContext : DbContext
    {
        public MvcBowlContext(DbContextOptions<MvcBowlContext> options)
            : base(options)
        {
        }

        public DbSet<Bowl> Bowl { get; set; }
    }
}
