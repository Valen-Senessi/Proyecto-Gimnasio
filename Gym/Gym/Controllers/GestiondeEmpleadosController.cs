using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class GestiondeEmpleadosController : Controller
    {
        public IActionResult Index()
        {   //https://localhost:7065/GestiondeEmpleados/index
            return View("~/Views/Admin/GestiondeEmpleados.cshtml");
        }
    }
}
