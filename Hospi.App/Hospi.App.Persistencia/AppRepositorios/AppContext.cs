using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Hospi.App.Dominio.Entidades;

namespace Hospi.App.Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; } 

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Server=localhost,1433;Initial Catalog=HospiData;User ID=SA;Password=YourSTRONG!Passw0rd");
                }
            }
    }
}