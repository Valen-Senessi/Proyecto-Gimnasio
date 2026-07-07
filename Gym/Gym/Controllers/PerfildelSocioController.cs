using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class PerfildelSocioController : Controller
    {
        public IActionResult Index()
        {   //https://localhost:7065/PerfildelSocio/index
            return View("~/Views/Socio/PerfildelSocio.cshtml");
        }
    }
}
