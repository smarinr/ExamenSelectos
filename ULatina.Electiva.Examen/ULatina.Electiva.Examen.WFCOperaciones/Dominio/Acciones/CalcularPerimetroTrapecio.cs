using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularPerimetroTrapecio
    {
        public CalcularPerimetroTrapecio()
        {

        }
        public double PerimetroTrapecio(double [] listaLados)
        {

            var miEspecifica = new Especificaciones.CalculeElPerimetroTrapecio();
            double result = miEspecifica.PerimetroTrapecio(listaLados);
            
            return result;
        }
        }
}