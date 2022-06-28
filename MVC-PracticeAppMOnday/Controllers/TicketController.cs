using Microsoft.AspNetCore.Mvc;
using MVC_PracticeAppMOnday.Models;

namespace MVC_PracticeAppMOnday.Controllers
{
    public class TicketController : Controller
    {

        private static List<TicketViewModel> tickets = new List<TicketViewModel>();
        public IActionResult Index()
        {
            /*TicketViewModel ticketItem = new TicketViewModel();*/
         /*   { Id = 123, Title = "First Ticket", TicketBody="Hello To the computer and internet I have Created a new ticket to be viewed on this application.", Complete=true };*/
            return View(tickets);
        }

        public IActionResult New()
        {
            /*NewTicketModel ticketItem = new NewTicketModel();*/
            
            var ticketVm = new TicketViewModel();
            return View(ticketVm);
        }

        public IActionResult NewTicket(TicketViewModel ticketViewModel)
        {
            // return View("Index");
            tickets.Add(ticketViewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
