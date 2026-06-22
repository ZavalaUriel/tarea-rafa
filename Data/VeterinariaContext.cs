using Microsoft.EntityFrameworkCore;
using Veterinaria.Models;

namespace Veterinaria.Data
{
    public class VeterinariaContext : DbContext
    {
        public VeterinariaContext(DbContextOptions<VeterinariaContext> options) : base(options)
        {
        }

        public DbSet<MascotaModel> Mascotas { get; set; }
        public DbSet<VeterinarioModel> Veterinarios { get; set; }
        public DbSet<CitaModel> Citas { get; set; }
        public DbSet<SucursalModel> Sucursales { get; set; }
    }
}
