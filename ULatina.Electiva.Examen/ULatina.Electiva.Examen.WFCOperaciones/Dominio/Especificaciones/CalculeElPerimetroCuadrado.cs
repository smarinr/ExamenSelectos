using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElPerimetroCuadrado
    {

        public CalculeElPerimetroCuadrado()
        {

        }

        public double CalcularPerime(double Lado)
        {


            var miValidacion = new Dominio.Validaciones.ValidacionParametroPositivo();
            bool valida = miValidacion.ValidarParametroPositivo(Lado);
            
            if (valida)
            {
                return Lado + Lado + Lado + Lado;
            }
            
            return 0;
        }
    }
}