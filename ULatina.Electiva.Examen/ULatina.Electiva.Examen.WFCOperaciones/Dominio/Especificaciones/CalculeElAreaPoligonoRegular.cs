using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElAreaPoligonoRegular
    {
        public CalculeElAreaPoligonoRegular()
        {
        }

        public double AreaPoligonoRegular(double NumeroLados, double Apotema, double PerimetroPoligonoRegular)
        {
            var validacionParametros = new Dominio.Validaciones.ValidacionParametroPositivo();
            var validacionLadosPoligonoRegular = new Dominio.Validaciones.ValidacionLadosPoligonoRegular();

            bool NumeroLadosValido = validacionLadosPoligonoRegular.ValidarLadosPoligonoRegular(NumeroLados);

            bool ApotemaValida = validacionParametros.ValidarParametroPositivo(Apotema);
            bool PerimetroValido = validacionParametros.ValidarParametroPositivo(PerimetroPoligonoRegular);

            if (NumeroLadosValido && ApotemaValida && PerimetroValido)
            {
                return (PerimetroPoligonoRegular * Apotema) / 2;
            }
            return 0;
        }

    }
}