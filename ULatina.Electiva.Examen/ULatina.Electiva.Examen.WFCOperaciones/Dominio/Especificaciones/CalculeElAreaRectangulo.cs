using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElAreaRectangulo
    {
        public CalculeElAreaRectangulo()
        {
        }

        public double AreaRectangulo(double Ancho, double Largo)
        {
            var validacionParametros = new Dominio.Validaciones.ValidacionParametroPositivo();

            bool AnchoValido = validacionParametros.ValidarParametroPositivo(Ancho);
            bool LargoValido = validacionParametros.ValidarParametroPositivo(Largo);

            if (AnchoValido && LargoValido)
            {
                return Ancho * Largo;
            }
            return 0;
        }

    }
}