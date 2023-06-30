using Empleados_23CV.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_23CV.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //AQUI va la cadena de conexion de bd
            optionsBuilder.UseMySQL("Server=localhost; database=Empleado23cv; user=root; password=; ");

        }
        public DbSet<Empleado> Empleados { get; set; }

    }
}
