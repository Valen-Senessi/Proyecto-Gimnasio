using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class EstadisticasFinancierasController : Controller
    {
        public IActionResult Index()
        {   //https://localhost:7065/EstadisticasFinancieras/index
            return View("~/Views/Admin/EstadisticasFinancieras.cshtml");
        }
    }
}
