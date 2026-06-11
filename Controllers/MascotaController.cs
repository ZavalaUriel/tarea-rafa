// File cleared by request

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Veterinaria.Models;
using System.Collections.Generic;

namespace Veterinaria.Controllers
{
    public class MascotaController : Controller
    {
        private static List<MascotaModel> mascotas = new List<MascotaModel>();

        public IActionResult Index()
        {
            return View("index", mascotas);
        }

        [HttpPost]
        public IActionResult Agregar(MascotaModel nuevaMascota)
        {
            if (nuevaMascota != null && !string.IsNullOrEmpty(nuevaMascota.nombre))
            {
                mascotas.Add(nuevaMascota);
            }
            return RedirectToAction(nameof(Index));
        }

      
    }
}