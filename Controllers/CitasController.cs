using Microsoft.AspNetCore.Mvc;
using Veterinaria.Data;
using Veterinaria.Models;
using System.Linq;

namespace Veterinaria.Controllers
{
    public class CitasController : Controller
    {
        private readonly VeterinariaContext _context;

        public CitasController(VeterinariaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var citasLista = _context.Citas.ToList();
            return View("index", citasLista);
        }

        [HttpPost]
        public IActionResult Agregar(CitasModel nuevaCita)
        {
            if (nuevaCita != null && !string.IsNullOrEmpty(nuevaCita.nombre))
            {
                if (System.DateTime.TryParse(nuevaCita.fecha, out System.DateTime parsedDate))
                {
                    nuevaCita.fecha = parsedDate.ToString("dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                }
                _context.Citas.Add(nuevaCita);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
