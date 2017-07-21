using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElVolumenPiramideCuadrada
    {
        public CalculeElVolumenPiramideCuadrada(){}

        public double CalculeVolumenPiramideCuadrada (double ladoBase, double altura)
        {
            var e = new Validaciones.CalculeValorPositivo();
            var accion = new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones.CalculeElAreaCuadrado();
            // Variable de Operacion
            double ladoBasePrueba = ladoBase;
            double alturaPrueba = altura;
            double areaCuadrado;

            // Variable salida
            double volumenResultado;
            
            if (e.ValidarLadosPostivos(ladoBase)&& e.ValidarLadosPostivos(altura))
            {
                areaCuadrado = accion.AreaCuadrado(ladoBasePrueba);
                volumenResultado = (areaCuadrado *alturaPrueba)/3;
                return volumenResultado;
            }
            return 0;
        }
    }
}