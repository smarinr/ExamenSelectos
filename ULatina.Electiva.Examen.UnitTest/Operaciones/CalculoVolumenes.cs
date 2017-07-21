using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Examen.UnitTest.Operaciones
{
    [TestClass]
    public class CalculoVolumenes
    {
        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularVolumenCilindro accionCalcularVolumenCilindro =
            new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularVolumenCilindro();
        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularVolumenCono accionCalcularVolumenCono =
            new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularVolumenCono();
        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularVolumenEsfera accionCalcularVolumenEsfera =
            new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularVolumenEsfera();
        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularVolumenPiramideCuadrada accionCalcularVolumenPiramideCuadrada =
            new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularVolumenPiramideCuadrada();
        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularVolumenPiramidePoligonal accionCalcularVolumenPiramidePoligonal =
            new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularVolumenPiramidePoligonal();
        ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularVolumenPrisma accionCalcularVolumenPrisma =
            new ULatina.Electiva.Examen.WFCOperaciones.Dominio.Acciones.CalcularVolumenPrisma();

        [TestMethod]
        public void pruebaCilindro()
        {
            double volumenCilindroEsperado = 6283.2;
            double radio = 10;
            double altura = 20;
            double volumenCilnindroCalculado = Math.Round(accionCalcularVolumenCilindro.CalculeVolumenCilindro(radio, altura),2);
            Assert.AreEqual(volumenCilindroEsperado, volumenCilnindroCalculado);
        }

        [TestMethod]
        public void pruebaCono()
        {
            double volumenConoEsperado = 1047.2;
            double radio = 10;
            double altura = 10;
            double volumenConoCalculado = Math.Round(accionCalcularVolumenCono.CalculeVolumenCono(radio, altura), 2);
            Assert.AreEqual(volumenConoEsperado, volumenConoCalculado);
        }

        [TestMethod]
        public void pruebaEsfera()
        {
            double volumenEsferaEsperado = 4188.8;
            double radio = 10;
            double volumenEsferaCalculado = Math.Round(accionCalcularVolumenEsfera.CalculeVolumenDeUnaEsfera(radio), 2);
            Assert.AreEqual(volumenEsferaEsperado, volumenEsferaCalculado);
        }

        [TestMethod]
        public void pruebaPiramideCuadrada()
        {
            double volumenPiramideCuadrada = 333.33;
            double lado = 10;
            double radio = 10;
            double volumenPiramideCuadradaCalculada = Math.Round(accionCalcularVolumenPiramideCuadrada.CalculeVolumenPiramideCuadrada(lado, radio), 2);
            Assert.AreEqual(volumenPiramideCuadrada, volumenPiramideCuadradaCalculada);
        }

        [TestMethod]
        public void pruebaPrisma()
        {
            double volumenPrismaEsperado = 100;
            double largo = 2;
            double ancho = 5;
            double altura = 10;
            double volumenPrismaCalculada = Math.Round(accionCalcularVolumenPrisma.CalculeElVolumenDeUnPrisma(largo, ancho, altura), 2);
            Assert.AreEqual(volumenPrismaEsperado, volumenPrismaCalculada);
        }

    }
}
