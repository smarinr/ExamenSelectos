using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularVolumenPiramidePoligonal
    {
        public CalcularVolumenPiramidePoligonal() { }

        public double CalculeVolumenPiramudePoligonal(double altura, double apotema, double nLadoBase, double largoDelLado)
        {
            var laEspecificacion = new Especificaciones.CalculeElVolumenPiramidePoligonal();

            double elResultado;
            elResultado = laEspecificacion.CalculeVolumenPiramidePoligonal(altura, apotema, nLadoBase, largoDelLado);

            return elResultado;
        }
    }
}
