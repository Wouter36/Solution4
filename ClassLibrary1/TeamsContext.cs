using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class TeamsContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Speler> Spelers { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-353R5D9A\SQLEXPRESS;Initial Catalog=TeamsDB;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasAlternateKey(t => t.Stamnummer);
        }
    }
}
