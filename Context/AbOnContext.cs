using Context.Mapping.Task;
using Context.Mapping.User;
using Microsoft.EntityFrameworkCore;
using Entities.Models.TaskAggregate;
using Entities.Models.UserAggregate;

namespace Context
{
    public partial class AbOnContext : DbContext
    {
        public DbSet<AbTask> AbTask { get; set; }
        public DbSet<Delay> Delay { get; set; }
        public DbSet<Step> Step { get; set; }
        public DbSet<TaskDetails> TaskDetails { get; set; }
        public DbSet<Difficulty> Difficulty { get; set; }
        public DbSet<User> User { get; set; }

        public AbOnContext(DbContextOptions<AbOnContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AbTaskMapping());
            modelBuilder.ApplyConfiguration(new DelayMapping());
            modelBuilder.ApplyConfiguration(new DifficultyMapping());
            modelBuilder.ApplyConfiguration(new StepMapping());
            modelBuilder.ApplyConfiguration(new TaskDetailsMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());
        }
    }
}
