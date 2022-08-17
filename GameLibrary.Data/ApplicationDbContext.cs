using GameLibrary.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameLibrary.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<GameEntity> Games { get; set; }
        public DbSet<GameSystemEntity> GameSystem { get; set; }
        public DbSet<GenreEntity> Genre { get; set; }
    }
}