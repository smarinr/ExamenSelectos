using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElVolumenPiramidePoligonal
    {
        public CalculeElVolumenPiramidePoligonal() { }

        public double CalculeVolumenPiramidePoligonal(double altura, double apotema, double nLadoBase, double largoDelLado)
        {
            var e = new Validaciones.CalculeValorPositivo();
            var accion = new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones.CalculeElAreaPoligonoRegular();
            // Variable de Operacion
            double alturaPrueba = altura;
            double apotemaPrueba = apotema;
            double ladoBasePrueba = nLadoBase;
            double largoDeLadoPrueba = largoDelLado;
            double areaPoligono;

            // Variable Salida
            double volumenResultado;

            if (e.ValidarLadosPostivos(altura) && e.ValidarLadosPostivos(apotema) && e.ValidarLadosPostivos(nLadoBase)
                && e.ValidarLadosPostivos(largoDelLado))
            {
                areaPoligono = accion.AreaPoligonoRegular(ladoBasePrueba, apotemaPrueba, largoDeLadoPrueba);
                volumenResultado = (areaPoligono * alturaPrueba) / 3;
                return volumenResultado;
            }
            return 0;
        }
    }
}
