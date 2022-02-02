using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PotterPedia.Data
{
    public class PotterPediaDbContextFactory : IDesignTimeDbContextFactory<PotterPediaDbContext>
    {
        public PotterPediaDbContext CreateDbContext (string [] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PotterPediaDbContext> ();
            optionsBuilder.UseSqlite ("Data Source=potterpedia.db");

            return new PotterPediaDbContext (optionsBuilder.Options);
        }
    }
}
