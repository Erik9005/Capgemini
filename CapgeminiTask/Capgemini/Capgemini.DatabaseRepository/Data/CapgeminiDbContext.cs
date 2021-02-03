using Capgemini.Commons.Config;
using Capgemini.Commons.Models;
using Microsoft.EntityFrameworkCore;

namespace Capgemini.DatabaseRepository
{
    public class CapgeminiDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Config.CapgeminiConfig.ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                        .HasIndex(person => person.Id);
        }
    }
}