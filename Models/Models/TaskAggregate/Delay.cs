namespace Entities.Models.TaskAggregate
{
    public class Delay
    {
        public int Id { get; set; }
        public string Reason { get; set; }
        public string Time { get; set; }
        public string Solution { get; set; }
        public int TaskDetailsId { get; set; }
    }
}
