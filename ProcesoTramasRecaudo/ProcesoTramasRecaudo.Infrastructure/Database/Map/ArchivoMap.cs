using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProcesoTramasRecaudo.Infrastructure.Database.Entities;

namespace ProcesoTramasRecaudo.Infrastructure.Database.Map
{
    public class ArchivoMap : IEntityTypeConfiguration<Archivo>
    {
        public void Configure(EntityTypeBuilder<Archivo> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Estado).HasConversion<string>();
        }
    }
}
