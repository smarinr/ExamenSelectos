using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeValorPositivo

    {
        public bool ValidarLadosPostivos(double valorLado)
        {
            bool esLadoPositivo = true;
            double ValorParaValidar = 0;
            if (valorLado > ValorParaValidar)
            {
                return esLadoPositivo;
            }
            return esLadoPositivo;
        }
    }
}
