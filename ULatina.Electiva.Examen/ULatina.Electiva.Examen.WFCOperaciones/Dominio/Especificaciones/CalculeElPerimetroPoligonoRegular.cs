using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElPerimetroPoligonoRegular
    {

        public CalculeElPerimetroPoligonoRegular()
        {

        }

        public double CalcularPeriPoli(double Nlados, double lado)
        {

            var miValidacion1 = new Dominio.Validaciones.ValidacionLadosPoligonoRegular();
            var miValidacion2 = new Dominio.Validaciones.ValidacionParametroPositivo();
            bool valida1 = miValidacion1.ValidarLadosPoligonoRegular(Nlados);
            bool valida2 = miValidacion2.ValidarParametroPositivo(lado);

            if (valida1 && valida2)
            {
              return Nlados * lado;
            }
            return 0;
        
          
        }
    }
}