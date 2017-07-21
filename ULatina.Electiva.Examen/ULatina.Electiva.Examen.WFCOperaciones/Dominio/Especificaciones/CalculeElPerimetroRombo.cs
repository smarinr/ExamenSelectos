using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElPerimetroRombo
    {

        public CalculeElPerimetroRombo()
        {

        }

        public double CalcularPeriRombo(double ancho, double largo)
        {

            
            var miValidacion = new Dominio.Validaciones.ValidacionParametroPositivo();
            bool valida1 = miValidacion.ValidarParametroPositivo(ancho);
            bool valida2 = miValidacion.ValidarParametroPositivo(largo);
            double result;
            if (valida1 && valida2)
                
            {
                result= (ancho * largo);
                return result;
            }
            

            return 0;
        }
    }
}