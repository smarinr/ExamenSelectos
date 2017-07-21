using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElVolumenEsfera
    {
        public CalculeElVolumenEsfera(){}

        public double CalculeVolumenDeUnaEsfera (double radio)
        {
            var e = new Validaciones.CalculeValorPositivo();
            //Variables operacion
            double radioPrueba = radio;
            double resultadoVolumen;
            //Variable Auxiliar
            double pi = 3.1416;

            if (e.ValidarLadosPostivos(radio)){
                resultadoVolumen = (4 * pi * (radioPrueba * radioPrueba * radioPrueba)) / 3;
                return resultadoVolumen;
            }
            return 0;
        }
    }
}