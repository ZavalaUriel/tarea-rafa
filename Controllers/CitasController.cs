using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Veterinaria.Models;
using System.Collections.Generic;

namespace Veterinaria.Controllers
{
    public class CitasController : Controller
    {
        private static List<CitasModel> citas = new List<CitasModel>();

        public IActionResult Index()
        {
            return View("index", citas);
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
                citas.Add(nuevaCita);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
