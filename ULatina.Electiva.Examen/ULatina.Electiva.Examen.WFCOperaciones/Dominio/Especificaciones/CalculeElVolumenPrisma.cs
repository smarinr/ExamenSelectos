using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Especificaciones
{
    public class CalculeElVolumenPrisma
    {
        public CalculeElVolumenPrisma(){}

        public double CalculeElVolumenDeUnPrisma (double largo, double ancho, double altura)
        {

            var e = new Validaciones.CalculeValorPositivo();
            var accion = new Especificaciones.CalculeElAreaRectangulo();
            // Variables de Operacion
            double largoPrueba = largo;
            double anchoPrueba = ancho;
            double alturaPrueba = altura;

            // Variable Salida
            double volumenResultado;
            
            if (e.ValidarLadosPostivos(largo) && e.ValidarLadosPostivos(ancho)&& e.ValidarLadosPostivos(altura))
            {
                volumenResultado = (accion.AreaRectangulo(anchoPrueba, largoPrueba) * alturaPrueba);
                return volumenResultado;
            }

            return 0;
        }
    }
}