namespace Entities.Models.TaskAggregate
{
    public class Step
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int TaskDetailsId { get; set; }
    }
}
