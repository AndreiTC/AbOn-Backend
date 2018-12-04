using Entities.Models.TaskAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Context.Mapping.Task
{
    internal class DelayMapping : IEntityTypeConfiguration<Delay>
    {
        public void Configure(EntityTypeBuilder<Delay> builder)
        {
            builder.Property(e => e.Id)
                .HasColumnName("Id");

            builder.Property(e => e.Reason)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.Solution)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.Time)
                .HasColumnName("Time");
        }
    }
}
