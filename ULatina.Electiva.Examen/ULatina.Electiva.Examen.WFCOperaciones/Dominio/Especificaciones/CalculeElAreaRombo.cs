using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElAreaRombo
    {

        public CalculeElAreaRombo()
        {
        }

        public double AreaRombo(double DiagonalMayor, double DiagonalMenor)
        {
            var validacionParametros = new Dominio.Validaciones.ValidacionParametroPositivo();

            bool DiagonalMayorValido = validacionParametros.ValidarParametroPositivo(DiagonalMayor);
            bool DiagonalMenorValido = validacionParametros.ValidarParametroPositivo(DiagonalMenor);

            if (DiagonalMayorValido && DiagonalMenorValido)
            {
                return (DiagonalMayor * DiagonalMenor) / 2;
            }
            return 0;
        }

    }
}