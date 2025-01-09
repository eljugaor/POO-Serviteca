using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooServiteca.Classes
{
    public class Usuario
    {
        public string nombre;
        public int n_identificacion_Carro;
        public Usuario(string NOMBRE, int identificacion)
        {
            this.nombre = NOMBRE;
            this.n_identificacion_Carro = identificacion;
        }
    }

}
