using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using geoprofs.Models;

namespace geoprofs.Data
{
    public class geoprofsContext : DbContext
    {
        public geoprofsContext (DbContextOptions<geoprofsContext> options)
            : base(options)
        {
        }

        public DbSet<geoprofs.Models.Movie> Movie { get; set; } = default!;
    }
}
