using Ban.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ban.persistance
{
    internal class Config : IEntityTypeConfiguration<Bans>
    {
        public void Configure(EntityTypeBuilder<Bans> builder)
        {
            builder.HasIndex(w => w.id).IsUnique();
            builder.HasKey(w => w.id);

        }
    }
}
