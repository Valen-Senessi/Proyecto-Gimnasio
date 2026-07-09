using Gym.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Gym.Controllers
{
    public class CuentaUsuarioController : Controller
    {
        private readonly GymDbContext _context;
        public CuentaUsuarioController(GymDbContext context) => _context = context;

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var dniLimpio = new string(model.DNI.Where(char.IsDigit).ToArray());

            if (!int.TryParse(dniLimpio, out int dniNumerico))
            {
                ModelState.AddModelError(string.Empty, "DNI inválido");
                return View(model);
            }

            var usuario = await _context.Usuarios
                .Include(u => u.Perfil)
                .FirstOrDefaultAsync(u => u.DNI == dniNumerico);

            if ((usuario is null ) || !BCrypt.Net.BCrypt.Verify(model.UsuPsw, usuario.usuPsw))
            {
                ModelState.AddModelError(string.Empty, "DNI o contraseña incorrectos");
                return View(model);
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
                new Claim(ClaimTypes.Name, usuario.DNI.ToString()),
                new Claim(ClaimTypes.GivenName, $"{usuario.Nombre} {usuario.Apellido}"),
                new Claim(ClaimTypes.Role, usuario.Perfil?.Descripcion ?? string.Empty)
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(identity),
                new AuthenticationProperties { IsPersistent = false });

            return usuario.Perfil?.Descripcion switch
            {
                "Admin" => RedirectToAction("Index", "PaneldeAdministraciondeActivos"),
                "Empleado" => RedirectToAction("Index", ""),
                "Socio" => RedirectToAction("Index", "PaneldelSocioconPublicidad"),
                _ => RedirectToAction("Index", "Home")
            };
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}