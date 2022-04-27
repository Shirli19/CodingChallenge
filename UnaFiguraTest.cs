using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Figuras;
using CodingChallenge.Data.Classes.Idiomas.Idiomas;
using NUnit.Framework;


namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class UnaFiguraTest
    {
        #region Test para validar calculo area y perimetro de cada figura
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
            var resumen = ImprimirInformacion.Imprimir(ciculo, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1> 1 círculo | Área 50.27 | Perímetro 25.13 <br/>TOTAL:<br/> 1 forma Perímetro 25.13 Área 50.27".ToLower(), resumen.ToLower());
        }

        [TestCase]
        public void TestResumenListaConUnTrianguloIsoceles()
        {
            var triangulo = new List<FormaGeometrica> { new Triangulo(2, 4, 4) };
            var resumen = ImprimirInformacion.Imprimir(triangulo, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1> 1 triángulo | Área 3.87 | Perímetro 10 <br/>TOTAL:<br/> 1 forma Perímetro 10 Área 3.87".ToLower(), resumen.ToLower());
        }

        [TestCase]
        public void TestResumenListaConUnTrianguloEquilatero()
        {
            var triangulo = new List<FormaGeometrica> { new Triangulo(2) };
            var resumen = ImprimirInformacion.Imprimir(triangulo, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1> 1 triángulo | Área 1.73 | Perímetro 6 <br/>TOTAL:<br/> 1 forma Perímetro 6 Área 1.73".ToLower(), resumen.ToLower());
        }

        [TestCase]
        public void TestResumenListaConUnTrianguloEscaleno()
        {
            var triangulo = new List<FormaGeometrica> { new Triangulo(12, 6, 10) };
            var resumen = ImprimirInformacion.Imprimir(triangulo, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1> 1 triángulo | Área 29.93 | Perímetro 28 <br/>TOTAL:<br/> 1 forma Perímetro 28 Área 29.93".ToLower(), resumen.ToLower());
        }

        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var rectangulo = new List<FormaGeometrica> { new Rectangulo(4,6) };
            var resumen = ImprimirInformacion.Imprimir(rectangulo, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1> 1 rectángulo | Área 24 | Perímetro 20 <br/>TOTAL:<br/> 1 forma Perímetro 20 Área 24".ToLower(), resumen.ToLower());
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var trapecio = new List<FormaGeometrica> { new Trapecio(7, 4, 4.47m, 4.12m) };
            var resumen = ImprimirInformacion.Imprimir(trapecio, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1> 1 trapecio | Área 21.98 | Perímetro 19.59 <br/>TOTAL:<br/> 1 forma Perímetro 19.59 Área 21.98".ToLower(), resumen.ToLower());
        }

        [TestCase]
        public void TestResumenListaConOtroTrapecio()
        {
            var trapecio = new List<FormaGeometrica> { new Trapecio(7, 3, 5, 4.12m) };
            var resumen = ImprimirInformacion.Imprimir(trapecio, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1> 1 trapecio | Área 19.99 | Perímetro 19.12 <br/>TOTAL:<br/> 1 forma Perímetro 19.12 Área 19.99".ToLower(), resumen.ToLower());
        }
        #endregion


    }
}
