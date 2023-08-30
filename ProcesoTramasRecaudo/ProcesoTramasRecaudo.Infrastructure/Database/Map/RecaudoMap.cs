using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProcesoTramasRecaudo.Infrastructure.Database.Entities;

namespace ProcesoTramasRecaudo.Infrastructure.Database.Map
{
    public class RecaudoMap : IEntityTypeConfiguration<Recaudo>
    {
        public void Configure(EntityTypeBuilder<Recaudo> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
