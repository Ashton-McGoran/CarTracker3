using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarTracker2.Data
{
    public class CarTrackerContext : DbContext
    {
        public CarTrackerContext (DbContextOptions<CarTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Car { get; set; } = default!;
    }
}
