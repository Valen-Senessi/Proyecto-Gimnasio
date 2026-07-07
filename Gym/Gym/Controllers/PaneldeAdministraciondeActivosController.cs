using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class PaneldeAdministraciondeActivosController : Controller
    {
        public IActionResult Index()
        {   //https://localhost:7065/PaneldeAdministraciondeActivos/index
            return View("~/Views/Admin/PaneldeAdministraciondeActivos.cshtml");
        }
    }
}
