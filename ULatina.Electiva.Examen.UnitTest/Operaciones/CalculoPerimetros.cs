using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Examen.UnitTest
{
    [TestClass]
    public class CalculoPerimetros
    {

        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularPerimetroCuadrado accionCalcularPerimetroCuadrado = new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularPerimetroCuadrado();
        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularPerimetroPoligonoRegular accionCalcularPerimetroPoligono = new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularPerimetroPoligonoRegular();
        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularPerimetroRectangulo accionCalcularPerimetroRectangular = new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularPerimetroRectangulo();
        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularPerimetroRombo accionCalcularPerimetroRombo = new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularPerimetroRombo();
        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularPerimetroRomboide accionCalcularPerimetroRomboide = new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularPerimetroRomboide();
        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularPerimetroTrapecio accionCalcularPerimetroTrapecio = new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularPerimetroTrapecio();
        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularPerimetroTriangulo accionCalcularPerimetroTriangulo = new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularPerimetroTriangulo();
        

        [TestMethod]
        public void pruebaPerimetroCuadrado()
        {

            double perimetroEsperado = 16;

            double lado= 4;

            double perimetro = accionCalcularPerimetroCuadrado.PerimetroCuadrado(lado);

            Assert.AreEqual(perimetroEsperado,perimetro);
        }


        [TestMethod]
        public void pruebaPoligonoRegular()
        {

            double perimetroEsperado= 32;

            double ladoN = 8;

            double lado = 4;
            double perimetro = accionCalcularPerimetroPoligono.PerimetroPoligonoRegular(ladoN, lado);

            Assert.AreEqual(perimetroEsperado,perimetro);
        }


        [TestMethod]
        public void pruebaRectangulo()
        {

            double perimetroEsperado = 16;

            double ancho = 3;

            double largo = 5;

            double perimetro = accionCalcularPerimetroRectangular.PerimetroRectangularCalcular(ancho, largo);

            Assert.AreEqual(perimetroEsperado, perimetro);

        }
        [TestMethod]
        public void pruebaRombo()
        {

            double perimetroEsperado = 20;

            double ancho = 4;

            double largo = 5;

            double perimetro = accionCalcularPerimetroRombo.PerimetroRomboCalcular(ancho,largo);

            Assert.AreEqual(perimetroEsperado, perimetro);


        }
        [TestMethod]
        public void pruebaRomboide()
        {
            double perimetroEsperado = 24;

            double ancho = 8;

            double largo = 4;

            double perimetro = accionCalcularPerimetroRomboide.PerimetroRomboideCalcular(largo,ancho);

            Assert.AreEqual(perimetroEsperado, perimetro);
            

        }


        [TestMethod]
        public void pruebaTrapecio()
        {

            double perimetroEsperado = 18;

            
            double[] listaLados = { 6,3,4,5};

            double perimetro = accionCalcularPerimetroTrapecio.PerimetroTrapecio(listaLados);

            Assert.AreEqual(perimetroEsperado, perimetro);



        }
        [TestMethod]
        public void pruebaTriangulo()
        {
            double ResultadoEsperado = 125;

            
            double[] listaLados = {60,45,20};
            
            double perimetro = accionCalcularPerimetroTriangulo.PerimetroTriangulo(listaLados);

            Assert.AreEqual(ResultadoEsperado, perimetro);


        }


    }
}
