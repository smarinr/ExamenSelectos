using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Validaciones
{
    public class ValidacionTrianguloValido
    {
        public ValidacionTrianguloValido()
        {

        }

        public bool ValidarTrianguloValido(double lado1, double lado2, double lado3)
        {
            double ladoLargo, ladoCorto1, ladoCorto2;
            bool resultado;

            if (lado1 > lado2 && lado1 > lado3) //lado1 es el mas largo
            {
                ladoLargo = lado1;
                ladoCorto1 = lado2;
                ladoCorto2 = lado3;
            }
            else if (lado2 > lado1 && lado2 > lado3) //lado2 es el mas largo
            {
                ladoLargo = lado2;
                ladoCorto1 = lado1;
                ladoCorto2 = lado3;
            }
            else//lado3 es el mas largo
            {
                ladoLargo = lado3;
                ladoCorto1 = lado1;
                ladoCorto2 = lado2;
            }

            if ((ladoCorto1 + ladoCorto2) < ladoLargo) //se cumple la regla lado largo < lados cortos
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }
    }
}