using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProcesoTramasRecaudo.Infrastructure.Database.Entities;

namespace ProcesoTramasRecaudo.Infrastructure.Database.Map
{
    public class LogMap : IEntityTypeConfiguration<Log>
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.TipoDeLog).HasConversion<string>();
        }
    }
}
