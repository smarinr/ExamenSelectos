using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularPerimetroRectangulo
    {

        public CalcularPerimetroRectangulo()
        {

        }


        public double PerimetroRectangularCalcular(double Ancho, double largo)
        {

            var miEspecifica = new Especificaciones.CalculeElPerimetroRectangulo();
            double result = miEspecifica.CalcularPeriRecta(Ancho, largo);

            return result;
        }
    }
}