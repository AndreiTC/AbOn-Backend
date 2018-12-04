using Entities.Models.TaskAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Context.Mapping.Task
{
    internal class StepMapping : IEntityTypeConfiguration<Step>
    {
        public void Configure(EntityTypeBuilder<Step> builder)
        {
            builder.Property(e => e.Id)
                .HasColumnName("Id");

            builder.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
        }
    }
}
