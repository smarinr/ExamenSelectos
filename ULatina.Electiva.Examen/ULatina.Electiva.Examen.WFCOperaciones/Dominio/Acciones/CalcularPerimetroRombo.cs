using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularPerimetroRombo
    {

        public CalcularPerimetroRombo()
        {

        }


        public double PerimetroRomboCalcular( double ancho,double largo)
        {

            var miEspecifica = new Especificaciones.CalculeElPerimetroRombo();
            double result = miEspecifica.CalcularPeriRombo(ancho,largo);

            return result;
        }
    }
}