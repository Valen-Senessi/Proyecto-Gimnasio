using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class GestiondeSociosControllercs : Controller
    {
        public IActionResult Index()
        {   //https://localhost:7065/GestiondeSocios/index
            return View("~/Views/Admin/GestiondeSocios.cshtml");
        }
    }
}
