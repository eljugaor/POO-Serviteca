using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooServiteca.Classes
{
    public class Serviteca {

        public List<Mantenimientos> TipoMantenimiento = new List<Mantenimientos> {};
        public String NombreMantenimiento;
        public static void MantenimientoARealizar(Carro CarroReparar, Serviteca Mantenimiento)
        {
            char ElejirMantenimiento;
            List<Mantenimientos> ServiciosAEliminar = new List<Mantenimientos>();
            float Precio = 0;
            Console.WriteLine($"Este es el mantenimiento {Mantenimiento.NombreMantenimiento}:");
            foreach(var item in Mantenimiento.TipoMantenimiento)
            {
                Console.WriteLine($"- {item.NombreActividad}");
            }

            foreach(var item in Mantenimiento.TipoMantenimiento)
            {
                Console.WriteLine($"¿Desea incluir en el mantenimiento el siguiente servicio? (s/n): {item.NombreActividad}");
                ElejirMantenimiento = Console.ReadLine()[0];
                ElejirMantenimiento = char.ToUpper(ElejirMantenimiento);
                switch (ElejirMantenimiento)
                {
                    case 'S':
                        Precio += item.PrecioMantenimiento;
                        break;
                    case 'N':
                        ServiciosAEliminar.Add(item);
                        break;
                    default:
                        Console.WriteLine("Se tomara la opción ingresada como un no");
                        ServiciosAEliminar.Add(item);
                        break;
                }
            }

            //se aplica un foreach para eliminar las actividades del mantenimiento que no se eligieron 
            foreach(var item in ServiciosAEliminar)
            {
                Mantenimiento.TipoMantenimiento.Remove(item);
            }
            Precio = (Precio*CarroReparar.tipocarro.MultiplicadorPrecio) + Precio;
            Console.WriteLine("Procesando....\r");
            ImprimirRecibo(Precio, Mantenimiento, CarroReparar);
        }
        private static void ImprimirRecibo(float PrecioFinal, Serviteca Mantenimiento, Carro Multiplicador)
        {
            Console.WriteLine("Nombre Servicio  ....................  Precio Servicio");
            Console.WriteLine("_______________________________________________________________");
            foreach(var item in Mantenimiento.TipoMantenimiento )
            {
                Console.WriteLine($"-  {item.NombreActividad}  ....................   {item.PrecioMantenimiento}");
            }
            Console.WriteLine($"Multiplicador por tipo de carro                       {Multiplicador.tipocarro.MultiplicadorPrecio}");
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine($"Total                                              ${PrecioFinal}"); 
        }
    }
}
