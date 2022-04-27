using Microsoft.EntityFrameworkCore;

namespace RankingApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ranking> Rankings { get; set; } = null!;
    }
}