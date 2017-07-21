using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularVolumenEsfera
    {
        public CalcularVolumenEsfera(){}

        public double CalculeVolumenDeUnaEsfera(double radio)
        {
            var laEspecificacion = new Especificaciones.CalculeElVolumenEsfera();

            double elResultado;

            elResultado = laEspecificacion.CalculeVolumenDeUnaEsfera(radio);
            return elResultado;

        }
    }
}