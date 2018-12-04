using System;

namespace Entities.ViewModels.AbTask
{
    public class AbTaskViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DifficultyViewModel Difficulty { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public TaskDetailsViewModel TaskDetails { get; set; }
    }
}
