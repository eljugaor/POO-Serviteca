using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooServiteca.Classes
{
    public class Mantenimientos
    {
        public String NombreActividad;
        public float PrecioMantenimiento;
        public Mantenimientos(String Nombre, float Precio)
        {
            NombreActividad = Nombre;
            PrecioMantenimiento = Precio;
        }
    }
}
