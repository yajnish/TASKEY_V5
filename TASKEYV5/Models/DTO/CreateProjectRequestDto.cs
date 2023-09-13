namespace TASKEYV5.Models.DTO
{
    public class CreateProjectRequestDto
    {
        public string Title { get; set; }
        public string Version { get; set; }
        public Guid ProjectManager { get; set; }
    }
}
