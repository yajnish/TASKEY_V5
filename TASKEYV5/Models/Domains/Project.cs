using System;
namespace TASKEYV5.Models.Domains
{
    public class Project
    {
        public Guid id { get; set; }
        public string Title { get; set; }
        public string Version { get; set; }
        public Guid ProjectManager { get; set; }
    }
}
