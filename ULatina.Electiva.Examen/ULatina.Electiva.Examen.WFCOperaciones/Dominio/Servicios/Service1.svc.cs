using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Examen
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        string IService1.GetData(int value)
        {
            throw new NotImplementedException();
        }

        CompositeType IService1.GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }

        public double ObtenerAreaCuadrado(double lado)
        {
            throw new NotImplementedException();
        }

        public double ObtenerAreaPoligonoRegular(double apotema, double cantidadLados, double largoLado)
        {
            throw new NotImplementedException();
        }

        public double ObtenerAreaRectangulo(double ancho, double largo)
        {
            throw new NotImplementedException();
        }

        public double ObtenerAreaRombo(double diagonalMayor, double diagonalMenor)
        {
            throw new NotImplementedException();
        }

        public double ObtenerAreaRomboide(double baseRomboide, double alturaRomboide)
        {
            throw new NotImplementedException();
        }

        public double ObtenerAreaTrapecio(double baseMayor, double baseMenor, double altura)
        {
            throw new NotImplementedException();
        }

        public double ObtenerAreaTriangulo(IList lados)
        {
            throw new NotImplementedException();
        }

        public double ObtenerPerimetroCuadrado(double lado)
        {
            throw new NotImplementedException();
        }

        public double ObtenerPerimetroPoligonoRegular(double cantidadLados, double largoLados)
        {
            throw new NotImplementedException();
        }

        public double ObtenerPerimetroRectangulo(double ancho, double largo)
        {
            throw new NotImplementedException();
        }

        public double ObtenerPerimetroRombo(double ancho, double largo)
        {
            throw new NotImplementedException();
        }

        public double ObtenerPerimetroRomboide(double ancho, double largo)
        {
            throw new NotImplementedException();
        }

        public double ObtenerPerimetroTrapecio(IList lados)
        {
            throw new NotImplementedException();
        }

        public double ObtenerPerimetroTriangulo(IList lados)
        {
            throw new NotImplementedException();
        }

        public double ObtenerVolumenCilindro(double radio, double altura)
        {
            throw new NotImplementedException();
        }

        public double ObtenerVolumenCono(double radio, double altura)
        {
            throw new NotImplementedException();
        }

        public double ObtenerVolumenCubo(double arista)
        {
            throw new NotImplementedException();
        }

        public double ObtenerVolumenEsfera(double radio)
        {
            throw new NotImplementedException();
        }

        public double ObtenerVolumenPiramideCuadrada(double ladoBase, double altura)
        {
            throw new NotImplementedException();
        }

        public double ObtenerVolumenPiramidePoligonal(double altura, double apotema, double cantidadLadosBase, double largoLadoBase)
        {
            throw new NotImplementedException();
        }

        public double ObtenerVolumenPrisma(double ancho, double largo, double altura)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerAreaCuadrado(double lado)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerAreaPoligonoRegular(double apotema, double cantidadLados, double largoLado)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerAreaRectangulo(double ancho, double largo)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerAreaRombo(double diagonalMayor, double diagonalMenor)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerAreaRomboide(double baseRomboide, double alturaRomboide)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerAreaTrapecio(double baseMayor, double baseMenor, double altura)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerAreaTriangulo(IList lados)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerPerimetroCuadrado(double lado)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerPerimetroPoligonoRegular(double cantidadLados, double largoLados)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerPerimetroRectangulo(double ancho, double largo)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerPerimetroRombo(double ancho, double largo)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerPerimetroRomboide(double ancho, double largo)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerPerimetroTrapecio(IList lados)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerPerimetroTriangulo(IList lados)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerVolumenCilindro(double radio, double altura)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerVolumenCono(double radio, double altura)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerVolumenCubo(double arista)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerVolumenEsfera(double radio)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerVolumenPiramideCuadrada(double ladoBase, double altura)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerVolumenPiramidePoligonal(double altura, double apotema, double cantidadLadosBase, double largoLadoBase)
        {
            throw new NotImplementedException();
        }

        double IService1.ObtenerVolumenPrisma(double ancho, double largo, double altura)
        {
            throw new NotImplementedException();
        }
    }
}