using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularAreaTrapecio
    {
        public CalcularAreaTrapecio()
        {
        }

        public double AreaDelTrapecio(double BaseMayor, double BaseMenor, double Altura)
        {
            var EspecificacionTrapecio = new Especificaciones.CalculeElAreaTrapecio();
            double elResultado = EspecificacionTrapecio.AreaTrapecio(BaseMayor, BaseMenor, Altura);
            return elResultado;
        }
    }
}