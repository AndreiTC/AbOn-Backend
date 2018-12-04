using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Context.Mapping.User
{
    internal class UserMapping : IEntityTypeConfiguration<Entities.Models.UserAggregate.User>
    {
        public void Configure(EntityTypeBuilder<Entities.Models.UserAggregate.User> builder)
        {
            builder.Property(e => e.Id)
                .HasColumnName("Id");
            builder.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            builder.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            builder.Property(e => e.Password)
                .HasColumnName("HashPassword");
        }
    }
}
