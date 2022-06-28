namespace MVC_PracticeAppMOnday.Models
{
    public class ProjectViewModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime CompletionDate { get; set; }

        public bool IsCompleted { get; set; }
    }
}
