using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones

{
    public class CalculeElVolumenCilindro
    {
        public CalculeElVolumenCilindro(){}

        public double CalculeVolumenCilindro(double radio, double altura)
        {
            var e = new Validaciones.CalculeValorPositivo();
            // Variable auxiliar
            double pi = 3.1416;

            //Variable de operacion
            double radioPrueba = radio;
            double alturaPrueba = altura;
            double volumenTotal;

            if (e.ValidarLadosPostivos(radio) && e.ValidarLadosPostivos(altura)){
                volumenTotal = (radioPrueba * radioPrueba) * alturaPrueba * pi;
                return volumenTotal;
            }
            return 0;
        }

    }
}