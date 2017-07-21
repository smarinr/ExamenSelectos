using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Validaciones
{
    public class ValidacionLadosPoligonoRegular
    {
        public ValidacionLadosPoligonoRegular()
        {

        }

        public bool ValidarLadosPoligonoRegular(double nLadosPoligonoRegular)
        {
            return nLadosPoligonoRegular > 4;
        }

    }
}