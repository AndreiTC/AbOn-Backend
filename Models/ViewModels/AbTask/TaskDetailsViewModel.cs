using System.Collections.Generic;

namespace Entities.ViewModels.AbTask
{
    public class TaskDetailsViewModel
    {
        public int Id { get; set; }
        public string Goal { get; set; }
        public string TimeFrame { get; set; }
        public ICollection<DelayViewModel> Delays { get; set; }
        public ICollection<StepViewModel> Steps { get; set; }
    }
}
