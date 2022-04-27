using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Figuras;
using CodingChallenge.Data.Classes.Idiomas.Idiomas;
using NUnit.Framework;
namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class IdiomaTest
    {
        #region Test para validar los idiomas con una figura
        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };
            var resumen = ImprimirInformacion.Imprimir(cuadrados, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1> 1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/> 1 forma Perímetro 20 Área 25".ToLower(), resumen.ToLower());
        }

        [TestCase]
        public void TestResumenListaConUnCirculo()
        {
            var ciculo = new List<FormaGeometrica> { new Circulo(4) };
            var resumen = ImprimirInformacion.Imprimir(ciculo, new Ingles());

            Assert.AreEqual("<h1>Shapes Report</h1> 1 circle | Area 50.27 | Perimeter 25.13 <br/>TOTAL:<br/> 1 shape perimeter 25.13 area 50.27".ToLower(), resumen.ToLower());
        }

        [TestCase]
        public void TestResumenListaConUnTrianguloIsoceles()
        {
            var triangulo = new List<FormaGeometrica> { new Triangulo(2, 4, 4) };
            var resumen = ImprimirInformacion.Imprimir(triangulo, new Aleman());

            Assert.AreEqual("<h1>Shapes-Bericht</h1> 1 dreieck | flächeninhalt 3.87 | umfang 10 <br/>Gesamt:<br/> 1 formen umfang 10 flächeninhalt 3.87".ToLower(), resumen.ToLower());
        }

 
        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var rectangulo = new List<FormaGeometrica> { new Rectangulo(4, 6) };
            var resumen = ImprimirInformacion.Imprimir(rectangulo, new Italiano());

            Assert.AreEqual("<h1>Rapporto sulle forme</h1> 1 rettangolo | area 24 | Perimetro 20 <br/>TOTALE:<br/> 1 forme Perimetro 20 area 24".ToLower(), resumen.ToLower());
        }

        #endregion

        #region Test para validar los idiomas con varias figuras
        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5), new Cuadrado(4) };
            var resumen = ImprimirInformacion.Imprimir(cuadrados, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1> 2 Cuadrados | Área 41 | Perímetro 36 <br/>TOTAL:<br/> 2 formas Perímetro 36 Área 41".ToLower(), resumen.ToLower());
        }

        [TestCase]
        public void TestResumenListaConMasCirculos()
        {
            var ciculo = new List<FormaGeometrica> { new Circulo(4), new Circulo(6) };
            var resumen = ImprimirInformacion.Imprimir(ciculo, new Ingles());

            Assert.AreEqual("<h1>Shapes Report</h1> 2 circles | Area 163.36 | Perimeter 62.83 <br/>TOTAL:<br/> 2 shapes perimeter 62.83 area 163.36".ToLower(), resumen.ToLower());
        }

        [TestCase]
        public void TestResumenListaConMasTriangulosIsoceles()
        {
            var triangulo = new List<FormaGeometrica> { new Triangulo(2, 4, 4), new Triangulo(4, 6, 6) };
            var resumen = ImprimirInformacion.Imprimir(triangulo, new Aleman());

            Assert.AreEqual("<h1>Shapes-Bericht</h1> 2 dreiecke | flächeninhalt 15.19 | umfang 26 <br/>Gesamt:<br/> 2 formen umfang 26 flächeninhalt 15.19".ToLower(), resumen.ToLower());
        }


        [TestCase]
        public void TestResumenListaConMasRectangulos()
        {
            var rectangulo = new List<FormaGeometrica> { new Rectangulo(4, 6), new Rectangulo(8, 12) };
            var resumen = ImprimirInformacion.Imprimir(rectangulo, new Italiano());

            Assert.AreEqual("<h1>Rapporto sulle forme</h1> 2 rettangoli | area 120 | Perimetro 60 <br/>TOTALE:<br/> 2 forme Perimetro 60 area 120".ToLower(), resumen.ToLower());
        }

        #endregion
    }
}
