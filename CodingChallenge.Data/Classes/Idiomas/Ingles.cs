using CodingChallenge.Data.Classes.Figuras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Idiomas.Idiomas
{
    public class Ingles : IIdioma
    {

        private readonly List<NombreFiguras> figuras;
        public Ingles()
        {
            figuras = new List<NombreFiguras>();
            figuras.Add(new NombreFiguras() { figura = "cuadrado", nombre = "square", nombrePlural = "squares" });
            figuras.Add(new NombreFiguras() { figura = "rectangulo", nombre = "rectangle", nombrePlural = "rectangles" });
            figuras.Add(new NombreFiguras() { figura = "triangulo", nombre = "triangle", nombrePlural = "triangles" });
            figuras.Add(new NombreFiguras() { figura = "circulo", nombre = "circle", nombrePlural = "circles" });
            figuras.Add(new NombreFiguras() { figura = "trapecio", nombre = "trapeze", nombrePlural = "trapezoids" });

        }

        public string ImprimirHeader()
        {
            return "<h1>Shapes Report</h1> ";
        }

        public string ImprimirLinea(int cantidad, decimal area, decimal perimetro, string nombreForma)
        {
            return $"{cantidad} {nombreForma} | area {area:#.##} | perimeter {perimetro:#.##} <br/>";
        }

        public string ImprimirListaVacia()
        {
            return "<h1>Empty list of shapes!</h1>";
        }

        public string ImprimirNombreFigura(string figura)
        {
            var figura_find = figuras.Find(f => f.figura == figura);
            if (figura_find == null) throw new ArgumentOutOfRangeException(@"Unknown shape");
            return figura_find.nombre;
        }

        public string ImprimirNombrePluralFigura(string figura)
        {
            var figura_find = figuras.Find(f => f.figura == figura);
            if (figura_find == null) throw new ArgumentOutOfRangeException(@"Unknown shape");
            return figura_find.nombrePlural;
        }

        public string ImprimirTotal(int cantFormas, decimal totalPerimetro, decimal totalArea)
        {
            var forma = cantFormas > 1 ? "shapes" : "shape";
            return $"Total:<br/> {cantFormas} {forma} perimeter {totalPerimetro:#.##} area {totalArea:#.##}";
        }
    }
}
