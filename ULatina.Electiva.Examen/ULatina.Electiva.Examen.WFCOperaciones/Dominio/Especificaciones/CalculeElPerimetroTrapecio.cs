using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElPerimetroTrapecio
    {


        public CalculeElPerimetroTrapecio()
        {
                
        }


        public double PerimetroTrapecio(double []listaLados)
        {

            double result=0;
            
            var miValidacion1 = new Dominio.Validaciones.ValidacionParametroPositivo();
            var miValidacion2 = new Dominio.Validaciones.ValidacionLadosDiferentes();

            double lado1 = (Double)listaLados.GetValue(0);
            double lado2 = (Double)listaLados.GetValue(1);
            double lado3 = (Double)listaLados.GetValue(2);
            double lado4 = (Double)listaLados.GetValue(3);

            bool valida1 = miValidacion1.ValidarParametroPositivo(lado1);
            bool valida2= miValidacion1.ValidarParametroPositivo(lado2);
            bool valida3 = miValidacion1.ValidarParametroPositivo(lado3);
            bool valida4 = miValidacion1.ValidarParametroPositivo(lado4);
            bool valida5 = miValidacion2.ValidarLadosDiferentes(lado1, lado2, lado3, lado4);

            if (valida1 && valida2 && valida3 && valida4)
            {
                result = lado1+lado2+lado3+lado4;
            }

            return result;
        }


    }
}