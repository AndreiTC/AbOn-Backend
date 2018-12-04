using System;

namespace Entities.Models.TaskAggregate
{
    public class AbTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Difficulty Difficulty { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public TaskDetails TaskDetails { get; set; }
    }
}
