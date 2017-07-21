using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Examen.UnitTest.Operaciones
{
    [TestClass]
    public class CalculoDeAreas
    {

        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularAreaCuadrado accionCalcularAreaCuadrado = new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularAreaCuadrado();
        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularAreaRectangulo accionCalcularAreaRectangulo = new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularAreaRectangulo();
        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularAreaPoligonoRegular accionCalcularAreaPoligonoRegular = new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularAreaPoligonoRegular();
        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularAreaRombo accionCalcularAreaRombo = new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularAreaRombo();
        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularAreaRomboide accionCalcularAreaRomboide = new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularAreaRomboide();
        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularAreaTrapecio accionCalcularAreaTrapecio = new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularAreaTrapecio();
        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularAreaTriangulo accionCalcularAreaTriangulo = new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularAreaTriangulo();

        [TestMethod] public void pruebaCuadrado() {
            double areaEsperada = 4;
            double lado = 2;
            double areaCalculada = accionCalcularAreaCuadrado.AreaDelCuadrado(lado);
            Assert.AreEqual(areaEsperada, areaCalculada);
        }


        [TestMethod] public void pruebaPoligonoRegular() {
            double areaEsperada = 166.32;

            double NumeroLados = 6;
            double PerimetroPoligonoRegular = 48;
            double Apotema = 6.93;
        
            double areaCalculada = accionCalcularAreaPoligonoRegular.AreaDelPoligonoRegular(NumeroLados, PerimetroPoligonoRegular, Apotema);

            Assert.AreEqual(areaEsperada, areaCalculada);

         }


        [TestMethod] public void pruebaRectangulo() {
            double areaEsperada = 20;
            double Largo = 10;
            double Ancho = 2;
            double areaCalculada = accionCalcularAreaRectangulo.AreaDelRectangulo(Ancho, Largo);
            Assert.AreEqual(areaEsperada, areaCalculada);
        }

        [TestMethod] public void pruebaRombo() {
            double areaEsperada = 25;
            double DiagonalMayor = 10;
            double DiagonalMenor = 5;
            double areaCalculada = accionCalcularAreaRombo.AreaDelRombo(DiagonalMayor, DiagonalMenor);
            Assert.AreEqual(areaEsperada, areaCalculada);
        }

        [TestMethod] public void pruebaRomboide() {
            double areaEsperada = 100;
            double Base = 2;
            double altura = 50;
            double areaCalculada = accionCalcularAreaRomboide.AreaDelRomboide(Base, altura);
            Assert.AreEqual(areaEsperada, areaCalculada);

        }
        [TestMethod] public void pruebaTrapecio() {
            double areaEsperada = 18;
            double BaseMayor = 4;
            double BaseMenor = 2;            
            double altura = 6;
            double areaCalculada = accionCalcularAreaTrapecio.AreaDelTrapecio(BaseMenor, BaseMayor, altura);
            Assert.AreEqual(areaEsperada, areaCalculada);                      
        }


        [TestMethod] public void pruebaTriangulo() {
            double areaEsperada = 0;
            double semiPerimetro = 15;
            double[] listaLados = {semiPerimetro, 8,7};

            double areaCalculada = accionCalcularAreaTriangulo.AreaDelTriangulo(listaLados);
            Assert.AreEqual(areaEsperada, areaCalculada);

            //(semiPerimetro * (semiPerimetro - lado1) * (semiPerimetro - lado2) * (semiPerimetro - lado3));
        }
    }
}
