using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularPerimetroRomboide
    {

        public CalcularPerimetroRomboide()
        {

        }

        public double PerimetroRomboideCalcular(double largo, double ancho)
        {
            var miEspecifica = new Especificaciones.CalculeElPerimetroRomboide();
            double result = miEspecifica.CalcularPeriRomboide(ancho, largo);

            return result;

        }

    }
}