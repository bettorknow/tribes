using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tribes.Database.Management.CreateDatabase.Entities;

namespace Tribes.Database.Management.CreateDatabase
{
    public class TribesContext : DbContext
    {
        public DbSet<Clan> Clans { get; set; }
        public DbSet<Tribe> Tribes { get; set; }
        public DbSet<Member> Members { get; set; }

        public TribesContext()
            : base("Tribes")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.Configuration.LazyLoadingEnabled = false;

            modelBuilder.Entity<Clan>().HasKey(x => x.Id);
            modelBuilder.Entity<Tribe>().HasKey(x => x.Id);
        }

    }
}
