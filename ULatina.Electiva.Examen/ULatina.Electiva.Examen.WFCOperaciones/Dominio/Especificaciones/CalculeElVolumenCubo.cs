using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElVolumenCubo
    {
        public CalculeElVolumenCubo (){}

        public double CalcularVolumenDeCubo (double arista)
        {
            var e = new Validaciones.CalculeValorPositivo();
            // Variables operacion
            double aristaPrueba = arista;
            double volumenResultado;
        
            if (e.ValidarLadosPostivos(arista)){
            volumenResultado = aristaPrueba*aristaPrueba*aristaPrueba;
            return volumenResultado;
            }
            return 0;
        }
    }
}