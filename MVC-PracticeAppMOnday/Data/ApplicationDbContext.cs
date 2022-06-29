using Microsoft.EntityFrameworkCore;
using MVC_PracticeAppMOnday.Models;

namespace MVC_PracticeAppMOnday.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<TicketViewModel> Tickets { get; set; }
        public DbSet<ProjectViewModel> Projects { get; set; }

    }
}
