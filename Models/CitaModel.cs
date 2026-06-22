using System;

namespace Veterinaria.Models
{
    public class CitaModel
    {
        public int Id { get; set; }
        public string Mascota { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
    }
}
