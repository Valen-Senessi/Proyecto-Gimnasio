using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class CalendariodeAsistenciaController : Controller
    {
        public IActionResult Index()
        {   //https://localhost:7065/CalendariodeAsistencia/index
            return View("~/Views/Socio/CalendariodeAsistencia.cshtml");
        }
    }
}
