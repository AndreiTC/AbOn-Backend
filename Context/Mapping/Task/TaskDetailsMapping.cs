using Entities.Models.TaskAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Context.Mapping.Task
{
    internal class TaskDetailsMapping : IEntityTypeConfiguration<TaskDetails>
    {
        public void Configure(EntityTypeBuilder<TaskDetails> builder)
        {
            builder.Property(e => e.Id)
                .HasColumnName("Id");
            builder.Property(e => e.Goal)
                .HasMaxLength(255)
                .IsUnicode(false);
            builder.HasMany(e => e.Delays);
            builder.HasMany(e => e.Steps);
            builder.Property(e => e.TimeFrame)
                .HasColumnName("TimeFrame");
        }
    }
}
