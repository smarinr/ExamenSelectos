using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElPerimetroRomboide
    {

        public CalculeElPerimetroRomboide()
        {

        }


        public double CalcularPeriRomboide(double ancho, double largo)
        {

            double result;
            var miValidacion = new Dominio.Validaciones.ValidacionParametroPositivo();
            bool valida1 = miValidacion.ValidarParametroPositivo(ancho);
            bool valida2 = miValidacion.ValidarParametroPositivo(largo);
            if (valida1 && valida2)
            {
                result = 2 * (largo + ancho);
                return result;
            }

            return 0;
        }
    }
}