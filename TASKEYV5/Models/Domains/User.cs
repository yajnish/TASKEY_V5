namespace TASKEYV5.Models.Domains
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Position { get; set; }
        public bool IsManager { get; set; }
    }
}
