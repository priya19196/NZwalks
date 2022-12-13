using Microsoft.EntityFrameworkCore;
using NZwalks.API.model.Domain;

namespace NZwalks.API.Data
{
    public class NZwalksDbContext : DbContext
    {
        public NZwalksDbContext(DbContextOptions<NZwalksDbContext> options) : base(options) 
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty{ get; set; }
    }
}
