using Empleados_23CV.Context;
using Empleados_23CV.Entities;
using Microsoft.EntityFrameworkCore.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_23CV.Services
{
    public class Empleado_Services
    {
        public void Add(Empleado request) 
        {
			try
			{

				using (var _context = new ApplicationDbContext()) 
				{
                    Empleado empleado = new Empleado()
                    {
                        Nombre = request.Nombre,
                        Apellido = request.Apellido,
                        FechaRegistro = DateTime.Now,
                        Correo = request.Correo,
                    };
                    _context.Empleados.Add(empleado);   
                    _context.SaveChanges();

                }
					
			}
			catch (Exception ex)
			{

				throw new Exception ("Succedio un Error"+ ex.Message);
			}
        }
        public Empleado Read(int id)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    Empleado empleados = _context.Empleados.Find(id);
                    return empleados;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Sucedio un error " + ex.Message);
            }
        }

    }
}
