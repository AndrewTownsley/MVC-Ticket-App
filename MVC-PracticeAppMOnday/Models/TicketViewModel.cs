using System.ComponentModel.DataAnnotations;

namespace MVC_PracticeAppMOnday.Models
{
    public class TicketViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        public string? TicketBody { get; set; }

        public bool? Complete { get; set; }
    }
}
