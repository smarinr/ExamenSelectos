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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract] double ObtenerAreaCuadrado(double lado);
        [OperationContract] double ObtenerAreaPoligonoRegular(double apotema, double cantidadLados, double largoLado);
        [OperationContract] double ObtenerAreaRectangulo(double ancho, double largo);
        [OperationContract] double ObtenerAreaRombo(double diagonalMayor, double diagonalMenor);
        [OperationContract] double ObtenerAreaRomboide(double baseRomboide, double alturaRomboide);
        [OperationContract] double ObtenerAreaTrapecio(double baseMayor, double baseMenor, double altura);
        [OperationContract] double ObtenerAreaTriangulo(IList lados);
        [OperationContract] double ObtenerPerimetroCuadrado(double lado);
        [OperationContract] double ObtenerPerimetroPoligonoRegular(double cantidadLados, double largoLados);
        [OperationContract] double ObtenerPerimetroRectangulo(double ancho, double largo);
        [OperationContract] double ObtenerPerimetroRombo(double ancho, double largo);
        [OperationContract] double ObtenerPerimetroRomboide(double ancho, double largo);
        [OperationContract] double ObtenerPerimetroTrapecio(IList lados);
        [OperationContract] double ObtenerPerimetroTriangulo(IList lados);
        [OperationContract] double ObtenerVolumenCilindro(double radio, double altura);
        [OperationContract] double ObtenerVolumenCono(double radio, double altura);
        [OperationContract] double ObtenerVolumenCubo(double arista);
        [OperationContract] double ObtenerVolumenEsfera(double radio);
        [OperationContract] double ObtenerVolumenPiramideCuadrada(double ladoBase, double altura);
        [OperationContract] double ObtenerVolumenPiramidePoligonal(double altura, double apotema, double cantidadLadosBase, double largoLadoBase);
        [OperationContract] double ObtenerVolumenPrisma(double ancho, double largo, double altura);
        [OperationContract] string GetData(int value);
        [OperationContract] CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
