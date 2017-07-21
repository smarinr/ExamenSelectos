using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElPerimetroRectangulo
    {

        public CalculeElPerimetroRectangulo()
        {

        }


        public double CalcularPeriRecta(double ancho, double largo)
        {


            
            var miValidacion = new Dominio.Validaciones.ValidacionParametroPositivo();
            bool valida1 = miValidacion.ValidarParametroPositivo(ancho);
            bool valida2 = miValidacion.ValidarParametroPositivo(largo);
            if (valida1 && valida2)
            {
                return (ancho * 2) + (largo * 2);
            }
        
            ;    
        return 0;
            
        }
        
    }
}