using Microsoft.AspNetCore.Mvc;
using Veterinaria.Data;
using Veterinaria.Models;

namespace Veterinaria.Controllers
{
    public class SucursalesController : Controller
    {
        private readonly VeterinariaContext _context;

        public SucursalesController(VeterinariaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var sucursales = _context.Sucursales.ToList();
            return View("index", sucursales);
        }

        [HttpPost]
        public IActionResult Agregar(SucursalModel nuevaSucursal)
        {
            if (nuevaSucursal != null && !string.IsNullOrEmpty(nuevaSucursal.Nombre))
            {
                _context.Sucursales.Add(nuevaSucursal);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
