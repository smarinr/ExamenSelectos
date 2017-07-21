using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElAreaCuadrado
    {
        public CalculeElAreaCuadrado()
        {
        }

        public double AreaCuadrado(double Lado)
        {
            var validacionParametros = new Dominio.Validaciones.ValidacionParametroPositivo();

            bool LadoValido = validacionParametros.ValidarParametroPositivo(Lado);

            if (LadoValido)
            {
                return Lado * Lado;
            }
            return 0;
        }

    }
}