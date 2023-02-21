using Microsoft.EntityFrameworkCore;
using Ban.Domain;
namespace Ban.Application.Interfac
{
    public interface IBanContext
    {
        public DbSet<Bans> bans  { get; set; }
        Task<int> SaveChangesAsync(CancellationToken token);
    }
}
