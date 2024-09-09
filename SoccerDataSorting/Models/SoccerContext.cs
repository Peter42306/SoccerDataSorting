using Microsoft.EntityFrameworkCore;

namespace SoccerDataSorting.Models
{
    public class SoccerContext : DbContext
    {
        public SoccerContext(DbContextOptions<SoccerContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Players> Players { get; set; }
        public DbSet<Teams> Teams { get; set; }
    }
}
