using System.Collections.Generic;

namespace Entities.Models.TaskAggregate
{
    public class TaskDetails
    {
        public int Id { get; set; }
        public string Goal { get; set; }
        public string TimeFrame { get; set; }
        public ICollection<Delay> Delays { get; set; }
        public ICollection<Step> Steps { get; set; }
    }
}
