using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooServiteca.Classes;

public class TipoCarro
{
    public string Segmento;
    public float longitudMax;
    public float longitudMin;
    public int NplazasMax;
    public int NplazasMin;
    public float MultiplicadorPrecio;
    public TipoCarro(string segmentos, float longitudMin, float longitudesMaximas, int nplazasMin,  int NlugaresMax, float multiplicador)
    {
        this.Segmento = segmentos;
        this.longitudMax = longitudesMaximas;
        this.NplazasMax = NlugaresMax;
        this.longitudMin = longitudMin;
        this.NplazasMin = nplazasMin;
        this.MultiplicadorPrecio = multiplicador;
    }
}
