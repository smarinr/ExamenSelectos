using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones
{
    public class CalcularPerimetroTriangulo
    {

        public CalcularPerimetroTriangulo()
        {

        }


        public double PerimetroTriangulo(double [] Lados)
        {
            
            var miEspecifica = new Especificaciones.CalculeElPerimetroTriangulo();
            double result = miEspecifica.PerimetroTriangulo(Lados);
            return result;
        }
    }
}