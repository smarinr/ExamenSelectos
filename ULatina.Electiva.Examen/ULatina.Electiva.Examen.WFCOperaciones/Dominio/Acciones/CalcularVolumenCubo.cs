using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalcularVolumenCubo
    {
        public CalcularVolumenCubo(){}

        public double CalculeVolumenCubo (double arista)
        {
            var laEspecificacion = new Especificaciones.CalcularVolumenCubo();
            
            double elResultado;
            elResultado = laEspecificacion.CalculeVolumenCubo(arista);

            return elResultado;
        }
    }
}