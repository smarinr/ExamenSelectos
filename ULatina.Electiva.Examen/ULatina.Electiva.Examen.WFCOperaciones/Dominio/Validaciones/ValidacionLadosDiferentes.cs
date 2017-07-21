using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Validaciones
{
    public class ValidacionLadosDiferentes
    {

        public ValidacionLadosDiferentes()
        {

        }


        public bool ValidarLadosDiferentes(double valor1,
            double valor2, double valor3, double valor4)
        {
            bool result=true;

            if (valor1==valor2||valor1==valor2||valor1==valor4)
            {
                result= false;
            }

            if (valor2 == valor3 || valor2 == valor4)
            {
                result= false;
            }

            if (valor3 == valor4)
            {
                result= false;
            }

            return result;
        }
    }
}