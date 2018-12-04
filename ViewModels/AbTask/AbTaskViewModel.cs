using System;
using ViewModels.User;

namespace ViewModels.AbTask
{
    public class AbTaskViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DifficultyViewModel Difficulty { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public UserViewModel User { get; set; }
        public TaskDetailsViewModel TaskDetails { get; set; }
    }
}
