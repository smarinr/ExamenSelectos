using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularAreaTriangulo
    {
        public CalcularAreaTriangulo()
        {
        }

        public double AreaDelTriangulo(double[] Lados)
        {
            var EspecificacionTriangulo = new Especificaciones.CalculeElAreaTriangulo();
            double elResultado = EspecificacionTriangulo.AreaTriangulo(Lados);
            return elResultado;
        }
    }
}