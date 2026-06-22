using Microsoft.AspNetCore.Mvc;
using Veterinaria.Data;
using Veterinaria.Models;

namespace Veterinaria.Controllers
{
    public class VeterinariosController : Controller
    {
        private readonly VeterinariaContext _context;

        public VeterinariosController(VeterinariaContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VeterinarioModel veterinario)
        {
            if (ModelState.IsValid)
            {
                _context.Veterinarios.Add(veterinario);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(veterinario);
        }
    }
}
