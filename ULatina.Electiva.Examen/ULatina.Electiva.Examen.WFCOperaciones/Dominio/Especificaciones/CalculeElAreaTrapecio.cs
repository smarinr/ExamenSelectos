using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElAreaTrapecio
    {
        public CalculeElAreaTrapecio()
        {
        }

        public double AreaTrapecio(double BaseMayor, double BaseMenor, double Altura)
        {
            var validacionParametros = new Dominio.Validaciones.ValidacionParametroPositivo();

            bool BaseMayorValida = validacionParametros.ValidarParametroPositivo(BaseMayor);
            bool BaseMenorValida = validacionParametros.ValidarParametroPositivo(BaseMenor);
            bool AlturaValida = validacionParametros.ValidarParametroPositivo(Altura);

            if (BaseMayorValida && BaseMenorValida && AlturaValida)
            {
                return ((BaseMayor + BaseMenor) / 2) * Altura;
            }
            return 0;
        }

    }
}