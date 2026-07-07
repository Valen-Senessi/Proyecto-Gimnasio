using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class GestiondeSedesController : Controller
    {
        public IActionResult Index()
        {   //https://localhost:7065/GestiondeSedes/index
            return View("~/Views/Admin/GestiondeSedes.cshtml");
        }
    }
}
