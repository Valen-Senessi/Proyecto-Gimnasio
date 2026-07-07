using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class PaneldelSocioconPublicidadController : Controller
    {
        public IActionResult Index()
        {   //https://localhost:7065/PaneldelSocioconPublicidad/index
            return View("~/Views/Socio/PaneldelSocioconPublicidad.cshtml");
        }
    }
}
