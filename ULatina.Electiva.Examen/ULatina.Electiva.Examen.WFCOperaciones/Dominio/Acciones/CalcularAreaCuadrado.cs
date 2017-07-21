using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularAreaCuadrado
    {
        public CalcularAreaCuadrado()
        {
        }

        public double AreaDelCuadrado(double Lado)
        {
            var EspecificacionCuadrado = new Especificaciones.CalculeElAreaCuadrado();
            double elResultado = EspecificacionCuadrado.AreaCuadrado(Lado);
            return elResultado;
        }
    }
}