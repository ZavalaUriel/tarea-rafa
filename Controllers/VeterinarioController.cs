using Microsoft.AspNetCore.Mvc;
using Veterinaria.Data;
using Veterinaria.Models;
using System.Linq;

namespace Veterinaria.Controllers
{
    public class VeterinarioController : Controller
    {
        private readonly VeterinariaContext _context;

        public VeterinarioController(VeterinariaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var veterinarios = _context.Veterinarios.ToList();
            return View("index", veterinarios);
        }

        [HttpPost]
        public IActionResult Agregar(VeterinarioModel nuevoVeterinario)
        {
            if (nuevoVeterinario != null && !string.IsNullOrEmpty(nuevoVeterinario.nombre))
            {
                _context.Veterinarios.Add(nuevoVeterinario);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
