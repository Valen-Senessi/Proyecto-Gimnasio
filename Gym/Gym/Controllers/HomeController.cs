using System.Diagnostics;
using Gym.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GymDbContext _dbContext;           //Inyeccion de dependencia para usar todas las tablas de la DB

        public HomeController(ILogger<HomeController> logger, GymDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;                         //Inyeccion de dependencia para usar todas las tablas de la DB
        }

        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
