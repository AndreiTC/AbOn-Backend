using Entities.Models.TaskAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Context.Mapping.Task
{
    internal class AbTaskMapping : IEntityTypeConfiguration<AbTask>
    {
        public void Configure(EntityTypeBuilder<AbTask> builder)
        {
            builder.ToTable("AbTask");
            builder.Property(e => e.Id)
                .HasColumnName("Id");
            builder.Property(e => e.UserId)
                .HasColumnName("UserId");
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
            builder.HasOne(e => e.Difficulty);
            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(2000)
                .IsUnicode(false);
            builder.Property(e => e.Category)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
            builder.Property(e => e.Date)
                .HasColumnName("Date");
            builder.HasOne(e => e.TaskDetails);

            builder.HasKey(e => e.Id);
        }
    }
}
