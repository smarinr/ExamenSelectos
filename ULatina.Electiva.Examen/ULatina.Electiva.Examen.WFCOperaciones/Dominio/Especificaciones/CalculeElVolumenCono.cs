using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElVolumenCono

    {
        public CalculeElVolumenCono(){}

        public double CalcularVolumenDeCono (double altura, double radio)
        {
            var e = new Validaciones.CalculeValorPositivo();
            var laAccion = new Especificaciones.CalculeElVolumenCilindro();
            // Variables de Operacion
            double volumenResultado;
            
            if (e.ValidarLadosPostivos(radio) && e.ValidarLadosPostivos(altura)){
                volumenResultado = (laAccion.CalculeVolumenCilindro(radio, altura))/3; 
                return volumenResultado;
            }
            return 0;
        }

    }
}