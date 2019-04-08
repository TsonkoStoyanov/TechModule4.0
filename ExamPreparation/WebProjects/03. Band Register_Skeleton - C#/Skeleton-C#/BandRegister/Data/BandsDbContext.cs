using BandRegister.Models;
using Microsoft.EntityFrameworkCore;

namespace BandRegister.Data
{
    public class BandsDbContext : DbContext
    {
        public DbSet<Band> Bands { get; set; }

        private const string connectionString = @"Server=(localdb)\MSSQLLocalDB;DATABASE=BandsDb;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}