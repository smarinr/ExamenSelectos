using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElAreaRomboide
    {
        public CalculeElAreaRomboide()
        {
        }

        public double AreaRomboide(double Base, double Altura)
        {
            var validacionParametros = new Dominio.Validaciones.ValidacionParametroPositivo();

            bool BaseValida = validacionParametros.ValidarParametroPositivo(Base);
            bool AlturaValida = validacionParametros.ValidarParametroPositivo(Altura);

            if (BaseValida && AlturaValida)
            {
                return Base * Altura;
            }
            return 0;
        }
    }
}