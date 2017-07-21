using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularAreaRectangulo
    {
        public CalcularAreaRectangulo()
        {
        }

        public double AreaDelRectangulo(double Ancho, double Largo)
        {
            var EspecificacionRectangulo = new Especificaciones.CalculeElAreaRectangulo();
            double elResultado = EspecificacionRectangulo.AreaRectangulo(Ancho, Largo);
            return elResultado;
        }
    }
}