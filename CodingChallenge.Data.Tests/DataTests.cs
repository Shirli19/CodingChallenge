using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Figuras;
using CodingChallenge.Data.Classes.Idiomas.Idiomas;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        #region Listas vacias test para cada idioma
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>".ToLower(),
                ImprimirInformacion.Imprimir(new List<FormaGeometrica>(), new Castellano()).ToLower());
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>".ToLower(),
                ImprimirInformacion.Imprimir(new List<FormaGeometrica>(), new Ingles()).ToLower());
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnAleman()
        {
            Assert.AreEqual("<h1>Leere Formenliste!</h1>".ToLower(),
                ImprimirInformacion.Imprimir(new List<FormaGeometrica>(), new Aleman()).ToLower());
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>".ToLower(),
                ImprimirInformacion.Imprimir(new List<FormaGeometrica>(), new Italiano()).ToLower());
        }
        #endregion

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> {new Cuadrado(5)};
            var resumen = ImprimirInformacion.Imprimir(cuadrados, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1> 1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/> 1 forma Perímetro 20 Área 25".ToLower(), resumen.ToLower());
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = ImprimirInformacion.Imprimir(cuadrados, new Ingles());

            Assert.AreEqual("<h1>Shapes report</h1> 3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/> 3 shapes Perimeter 36 Area 35".ToLower(), resumen.ToLower());
        }

        #region Test con más tipos para cada idioma
        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(1.5m),
                new Triangulo(4),
                new Cuadrado(2),
                new Triangulo(9),
                new Circulo(1.375m),
                new Triangulo(4.2m)
            };

            var resumen = ImprimirInformacion.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1> 2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/> 7 shapes Perimeter 97.66 Area 91.65".ToLower(),
                resumen.ToLower());
        }


        [TestCase]
        public void TestResumenListaConMasTiposAleman()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(1.5m),
                new Triangulo(4),
                new Cuadrado(2),
                new Triangulo(9),
                new Circulo(1.375m),
                new Triangulo(4.2m)
            };

            var resumen = ImprimirInformacion.Imprimir(formas, new Aleman());

            Assert.AreEqual(
                "<h1>Shapes-Bericht</h1> 2 quadrate | flächeninhalt 29 | umfang 28 <br/>2 kreise | flächeninhalt 13.01 | umfang 18.06 <br/>3 dreiecke | flächeninhalt 49.64 | umfang 51.6 <br/>Gesamt:<br/> 7 formen umfang 97.66 flächeninhalt 91.65".ToLower(),
                resumen.ToLower());
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(1.5m),
                new Triangulo(4),
                new Cuadrado(2),
                new Triangulo(9),
                new Circulo(1.375m),
                new Triangulo(4.2m)
            };

            var resumen = ImprimirInformacion.Imprimir(formas, new Italiano());

            Assert.AreEqual(
                "<h1>Rapporto sulle forme</h1> 2 quadrati | area 29 | Perimetro 28 <br/>2 cerchi | area 13.01 | Perimetro 18.06 <br/>3 triangoli | Area 49.64 | Perimetro 51.6 <br/>TOTALE:<br/> 7 forme Perimetro 97.66 area 91.65".ToLower(),
                resumen.ToLower());
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(1.5m),
                new Triangulo(4),
                new Cuadrado(2),
                new Triangulo(9),
                new Circulo(1.375m),
                new Triangulo(4.2m)
            };

            var resumen = ImprimirInformacion.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1> 2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13.01 | Perímetro 18.06 <br/>3 Triángulos | Área 49.64 | Perímetro 51.6 <br/>TOTAL:<br/> 7 formas Perímetro 97.66 Área 91.65".ToLower(),
                resumen.ToLower());
        }
        #endregion
    }
}
