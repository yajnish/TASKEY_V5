namespace TASKEYV5.Models.DTO
{
    public class CreateUserRequestDto
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Position { get; set; }
        public bool IsManager { get; set; }
    }
}
