using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication.DataAccess.Model.ContextMapping
{
    public class EnumMap : IEntityTypeConfiguration<Enum>
    {
        public void Configure(EntityTypeBuilder<Enum> builder)
        {
            builder.ToTable("enum");
            builder.HasKey(x => x.EnumId);
            builder.Property(p => p.EnumId).HasColumnName("enum_id");
            builder.Property(p => p.Description).HasColumnName("description");

        }
    }
}
