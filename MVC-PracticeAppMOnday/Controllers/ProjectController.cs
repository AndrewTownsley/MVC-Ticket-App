using Microsoft.AspNetCore.Mvc;
using MVC_PracticeAppMOnday.Models;

namespace MVC_PracticeAppMOnday.Controllers
{
    public class ProjectController : Controller
    {

        private static List<ProjectViewModel> projects = new List<ProjectViewModel>();

        public IActionResult Index()
        {
            return View(projects);
        }

        public IActionResult New()
        {
            var projectVm = new ProjectViewModel();
            return View(projectVm);
        }

        public IActionResult NewProject(ProjectViewModel projectViewModel)
        {
            projects.Add(projectViewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
