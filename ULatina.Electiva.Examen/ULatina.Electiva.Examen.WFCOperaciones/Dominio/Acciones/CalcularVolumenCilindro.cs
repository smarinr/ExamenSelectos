using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularVolumenCilindro
    {
        public CalcularVolumenCilindro(){}

        public double CalculeVolumenCilindro(double radio, double altura)
        {
            var laEspecificacion = new Especificaciones.CalculeElVolumenCilindro();

            double elResultado;
            elResultado = laEspecificacion.CalculeVolumenCilindro(radio, altura);

            return elResultado;
        }
    }
}