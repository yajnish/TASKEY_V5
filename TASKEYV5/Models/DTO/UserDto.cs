namespace TASKEYV5.Models.DTO
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Position { get; set; }
        public bool IsManager { get; set; }
    }
}
