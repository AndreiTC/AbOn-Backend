using Entities.Models.TaskAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Context.Mapping.Task
{
    internal class DifficultyMapping : IEntityTypeConfiguration<Difficulty>
    {
        public void Configure(EntityTypeBuilder<Difficulty> builder)
        {
            builder.Property(e => e.Id)
                .HasColumnName("Id");

            builder.Property(e => e.DifficultyLevel)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
        }
    }
}
