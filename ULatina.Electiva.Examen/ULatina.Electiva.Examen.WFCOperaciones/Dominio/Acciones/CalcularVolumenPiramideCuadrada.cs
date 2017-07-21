using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularVolumenPiramideCuadrada
    {
        public CalcularVolumenPiramideCuadrada(){}

        public double CalculeVolumenPiramideCuadrada (double ladoBase, double altura)
        {
            var laEspecificacion = new Especificaciones.CalculeElVolumenPiramideCuadrada();
            double elResultado;
            elResultado = laEspecificacion.CalculeVolumenPiramideCuadrada(ladoBase, altura);
            
            return elResultado;
        }
    }
}