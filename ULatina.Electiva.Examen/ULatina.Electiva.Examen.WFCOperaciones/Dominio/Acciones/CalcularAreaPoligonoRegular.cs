using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularAreaPoligonoRegular
    {
        public CalcularAreaPoligonoRegular()
        {
        }

        public double AreaDelPoligonoRegular(double Apotema, double NumeroLados, double Lado)
        {
            var EspecificacionesPerimetroPoligonoRegular = new Especificaciones.CalculeElPerimetroPoligonoRegular();
            double PerimetroPoligonoRegular = EspecificacionesPerimetroPoligonoRegular.CalcularPeriPoli(NumeroLados, Lado);
            var EspecificacionesAreaPoligonoRegular = new Especificaciones.CalculeElAreaPoligonoRegular();
            double elResultadoA = EspecificacionesAreaPoligonoRegular.AreaPoligonoRegular(NumeroLados, Apotema, PerimetroPoligonoRegular);
            return elResultadoA;
        }
    }
}