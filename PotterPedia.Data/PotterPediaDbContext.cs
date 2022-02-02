using System;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PotterPedia.Data
{
    public class PotterPediaDbContext : DbContext
    {
        public string DbPath { get; }

        /* DbSets */

        public PotterPediaDbContext (DbContextOptions<PotterPediaDbContext> options) : base (options)
        {
            var path = new DirectoryInfo (Environment.CurrentDirectory);
            var dataDirectory = path.Parent.GetDirectories ("PotterPedia.Data").FirstOrDefault ();
            DbPath = Path.Join (dataDirectory?.FullName, "potterpedia.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring (DbContextOptionsBuilder options) => options.UseSqlite ($"Data Source={DbPath}");
    }
}
