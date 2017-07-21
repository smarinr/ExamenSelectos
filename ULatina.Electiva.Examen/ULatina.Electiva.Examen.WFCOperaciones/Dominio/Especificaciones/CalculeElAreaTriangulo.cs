using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElAreaTriangulo
    {
        public CalculeElAreaTriangulo()
        {
        }

        public double AreaTriangulo(double[] Lados)
        {
            double semiPerimetro, area, lado1, lado2, lado3;
            lado1 = (Double)Lados.GetValue(0);
            lado2 = (Double)Lados.GetValue(1);
            lado3 = (Double)Lados.GetValue(2);
            var validacionTriangulo = new Dominio.Validaciones.ValidacionTrianguloValido();

            bool esTrianguloValido = validacionTriangulo.ValidarTrianguloValido(lado1, lado2, lado3);

            if (esTrianguloValido)
            {
                semiPerimetro = (lado1 + lado2 + lado3) / 2;
                area = Math.Sqrt(semiPerimetro * (semiPerimetro - lado1) * (semiPerimetro - lado2) * (semiPerimetro - lado3));
                return area;
            }
            return 0;
        }

    }
}