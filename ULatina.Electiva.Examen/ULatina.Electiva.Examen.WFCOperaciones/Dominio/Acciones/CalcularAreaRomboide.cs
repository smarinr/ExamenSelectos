using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularAreaRomboide
    {
        public CalcularAreaRomboide()
        {
        }

        public double AreaDelRomboide(double Base, double Altura)
        {
            var EspecificacionRomboide = new Especificaciones.CalculeElAreaRomboide();
            double elResultado = EspecificacionRomboide.AreaRomboide(Base, Altura);
            return elResultado;
        }
    }
}