using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using PooServiteca.Classes;

namespace PooServiteca.Classes
{
    public class Carro:Usuario
    {
        public TipoCarro tipocarro;
        public string placa;
        public string colorplaca;
        public string colorcarroceria;
        public bool tieneradio;
        public Carro(string NOMBRE, int identificacion, TipoCarro tipodelcarro, string Nplaca, string colordeplaca, string colordecarroceria, bool radio)
            :base(NOMBRE, identificacion)
        {
            this.tipocarro = tipodelcarro;
            this.placa = Nplaca;
            this.colorplaca = colordeplaca;
            this.colorcarroceria = colordecarroceria;
            this.tieneradio = radio;
        }
    }
}
