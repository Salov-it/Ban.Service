using Ban.Domain;
using Ban.Application.Interfac;
using Microsoft.EntityFrameworkCore;
namespace Ban.persistance
{
    public class BanContext : DbContext, IBanContext
    {
        public DbSet<Bans> bans { get; set; }

        public BanContext(DbContextOptions<BanContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Config());
            base.OnModelCreating(modelBuilder);
        }
    }
}
