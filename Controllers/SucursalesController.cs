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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SucursalModel sucursal)
        {
            if (ModelState.IsValid)
            {
                _context.Sucursales.Add(sucursal);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(sucursal);
        }
    }
}
