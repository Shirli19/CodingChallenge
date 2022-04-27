using CodingChallenge.Data.Classes.Figuras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Idiomas.Idiomas
{
    public class Castellano : IIdioma
    {
        private readonly List<NombreFiguras> figuras; 
        public Castellano()
        {
            figuras = new List<NombreFiguras>();
            figuras.Add(new NombreFiguras() { figura = "cuadrado", nombre = "cuadrado", nombrePlural = "cuadrados"});
            figuras.Add(new NombreFiguras() { figura = "rectangulo", nombre = "rectángulo", nombrePlural = "rectángulos" });
            figuras.Add(new NombreFiguras() { figura = "triangulo", nombre = "triángulo", nombrePlural = "triángulos" });
            figuras.Add(new NombreFiguras() { figura = "circulo", nombre = "círculo", nombrePlural = "círculos" });
            figuras.Add(new NombreFiguras() { figura = "trapecio", nombre = "trapecio", nombrePlural = "trapecios" });

        }

        public string ImprimirHeader()
        {
            return "<h1>Reporte de formas</h1> ";
        }

        public string ImprimirLinea(int cantidad, decimal area, decimal perimetro, string nombreForma)
        {
            return $"{cantidad} {nombreForma} | área {area:#.##} | perímetro {perimetro:#.##} <br/>";
        }

        public string ImprimirListaVacia()
        {
            return "<h1>Lista vacía de formas!</h1>";
        }

        public string ImprimirNombreFigura(string figura)
        {
            var figura_find = figuras.Find(f => f.figura == figura);
            if(figura_find == null) throw new ArgumentOutOfRangeException(@"Forma desconocida");
            return figura_find.nombre;
        }

        public string ImprimirNombrePluralFigura(string figura)
        {
            var figura_find = figuras.Find(f => f.figura == figura);
            if (figura_find == null) throw new ArgumentOutOfRangeException(@"Forma desconocida");
            return figura_find.nombrePlural;
        }

        public string ImprimirTotal(int cantFormas, decimal totalPerimetro, decimal totalArea)
        {
            var forma = cantFormas > 1 ? "formas" : "forma";
            return $"Total:<br/> {cantFormas} {forma} perímetro {totalPerimetro:#.##} área {totalArea:#.##}";
        }

    }
}
