using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Validaciones
{
    public class ValidacionParametroPositivo
    {
        public ValidacionParametroPositivo()
        {

        }

        public bool ValidarParametroPositivo(double parametro)
        {
            bool resultado;

            if (parametro > 0)
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