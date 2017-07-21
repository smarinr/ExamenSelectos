using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularVolumenCono
    {
        public CalcularVolumenCono(){}

        public double CalculeVolumenCono (double altura, double radio)
        {
            var laEspecificacion = new Especificaciones.CalculeElVolumenCono();

            double elResultado;
            elResultado = laEspecificacion.CalcularVolumenDeCono(altura, radio);

            return elResultado;
        }
    }
}