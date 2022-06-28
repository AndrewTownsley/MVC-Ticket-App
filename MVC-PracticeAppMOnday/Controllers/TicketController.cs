using Microsoft.AspNetCore.Mvc;
using MVC_PracticeAppMOnday.Models;

namespace MVC_PracticeAppMOnday.Controllers
{
    public class TicketController : Controller
    {

        private static List<TicketViewModel> tickets = new List<TicketViewModel>();

        public IActionResult Index()
        {
            return View(tickets);
        }

        public IActionResult New()
        {            
            var ticketVm = new TicketViewModel();
            return View(ticketVm);
        }

        public IActionResult NewTicket(TicketViewModel ticketViewModel)
        {
            tickets.Add(ticketViewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
