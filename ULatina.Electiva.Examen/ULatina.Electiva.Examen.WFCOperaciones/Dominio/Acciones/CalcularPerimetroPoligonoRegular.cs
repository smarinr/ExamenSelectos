using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularPerimetroPoligonoRegular
    {

        public CalcularPerimetroPoligonoRegular()
        {

        }


        public double PerimetroPoligonoRegular( double Nlados, double lados)
        {

            var miEspecifica = new Especificaciones.CalculeElPerimetroPoligonoRegular();
            double result = miEspecifica.CalcularPeriPoli(Nlados, lados);

            return result;

        }
            }
}