using GameStore.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Data
{
    public class GameDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        private const string connectionString = @"Server=(localdb)\MSSQLLocalDB;DATABASE=GameDb;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}