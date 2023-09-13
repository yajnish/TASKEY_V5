namespace TASKEYV5.Models.DTO
{
    public class CreateTaskRequestDto
    {
        public Guid ProjectID_Task { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public string TaskStatus { get; set; }
        public Guid UserAssigned { get; set; }
    }
}
