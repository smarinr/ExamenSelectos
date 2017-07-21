using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularVolumenPrisma
    {
        public CalcularVolumenPrisma (){}

        public double CalculeElVolumenDeUnPrisma (double largo, double ancho, double altura)
        {
            var laEspecificacion = new Especificaciones.CalculeElVolumenPrisma();

            double elResultado;

            elResultado = laEspecificacion.CalculeElVolumenDeUnPrisma(largo, ancho, altura);
            return elResultado;

        }
    }
}