using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElPerimetroTriangulo
    {


        public CalculeElPerimetroTriangulo()
        {

        }


        public double PerimetroTriangulo(double [] Lados)
        {

            double result;
            double lado1 = (Double)Lados.GetValue(0);
            double lado2= (Double)Lados.GetValue(1);
            double lado3= (Double)Lados.GetValue(2);


            var miValidacion = new Dominio.Validaciones.ValidacionTrianguloValido();
            bool valida = miValidacion.ValidarTrianguloValido(lado1, lado2, lado3);
            if (valida==true)
            {
                 
                result = lado1 + lado2 + lado3;
                return result;
            }
            
            return 0;
        }

    }
}