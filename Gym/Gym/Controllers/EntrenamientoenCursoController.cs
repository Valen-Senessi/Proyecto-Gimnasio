using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class EntrenamientoenCursoController : Controller
    {
        public IActionResult Index()
        {   //https://localhost:7065/EntrenamientoenCurso/index
            return View("~/Views/Socio/EntrenamientoenCurso.cshtml");
        }
    }
}
