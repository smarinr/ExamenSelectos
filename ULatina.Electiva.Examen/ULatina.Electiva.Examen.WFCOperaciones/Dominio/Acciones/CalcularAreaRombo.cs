using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularAreaRombo
    {
        public CalcularAreaRombo()
        {
        }

        public double AreaDelRombo(double DiagonalMayor, double DiagonalMenor)
        {
            var EspecificacionRombo = new Especificaciones.CalculeElAreaRombo();
            double elResultado = EspecificacionRombo.AreaRombo(DiagonalMayor, DiagonalMenor);
            return elResultado;
        }
    }
}