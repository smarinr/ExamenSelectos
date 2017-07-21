using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularPerimetroCuadrado
    {

        public CalcularPerimetroCuadrado()
        {

        }



        public double PerimetroCuadrado(double Lado) {

            var miEspecifica = new Especificaciones.CalculeElPerimetroCuadrado();
            double result = miEspecifica.CalcularPerime(Lado);
            return result;
        }
    }
}