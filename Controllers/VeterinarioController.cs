using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Veterinaria.Models;
using System.Collections.Generic;

namespace Veterinaria.Controllers
{
    public class VeterinarioController : Controller
    {
        private static List<VeterinarioModel> veterinarios = new List<VeterinarioModel>();

        public IActionResult Index()
        {
            return View("index", veterinarios);
        }

        [HttpPost]
        public IActionResult Agregar(VeterinarioModel nuevoVeterinario)
        {
            if (nuevoVeterinario != null && !string.IsNullOrEmpty(nuevoVeterinario.nombre))
            {
                veterinarios.Add(nuevoVeterinario);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
