using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpringFurniture.Models;

namespace SpringFurniture.Data
{
    public class SpringFurnitureContext : DbContext
    {
        public SpringFurnitureContext (DbContextOptions<SpringFurnitureContext> options)
            : base(options)
        {
        }

        public DbSet<SpringFurniture.Models.Movie> Movie { get; set; } = default!;
    }
}
