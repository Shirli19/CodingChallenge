using CodingChallenge.Data.Classes.Figuras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Idiomas.Idiomas
{
    public class Aleman : IIdioma
    {
        private readonly List<NombreFiguras> figuras;

        public Aleman()
        {
            figuras = new List<NombreFiguras>();
            figuras.Add(new NombreFiguras() { figura = "cuadrado", nombre = "quadrat", nombrePlural = "quadrate" });
            figuras.Add(new NombreFiguras() { figura = "rectangulo", nombre = "rechteck", nombrePlural = "rechtecke" });
            figuras.Add(new NombreFiguras() { figura = "triangulo", nombre = "dreieck", nombrePlural = "dreiecke" });
            figuras.Add(new NombreFiguras() { figura = "circulo", nombre = "kreis", nombrePlural = "kreise" });
            figuras.Add(new NombreFiguras() { figura = "trapecio", nombre = "trapez", nombrePlural = "trapeze" });

        }

        public string ImprimirHeader()
        {
            return "<h1>Shapes-Bericht</h1> ";
        }

        public string ImprimirLinea(int cantidad, decimal area, decimal perimetro, string nombreForma)
        {
            return $"{cantidad} {nombreForma} | flächeninhalt {area:#.##} | umfang {perimetro:#.##} <br/>";
        }

        public string ImprimirListaVacia()
        {
            return "<h1>Leere Formenliste!</h1>";
        }

        public string ImprimirNombreFigura(string figura)
        {
            var figura_find = figuras.Find(f => f.figura == figura);
            if (figura_find == null) throw new ArgumentOutOfRangeException(@"Unbekannte Gestalt");
            return figura_find.nombre;
        }

        public string ImprimirNombrePluralFigura(string figura)
        {
            var figura_find = figuras.Find(f => f.figura == figura);
            if (figura_find == null) throw new ArgumentOutOfRangeException(@"Unbekannte Gestalt");
            return figura_find.nombrePlural;
        }

        public string ImprimirTotal(int cantFormas, decimal totalPerimetro, decimal totalArea)
        {

            return $"Gesamt:<br/> {cantFormas} formen umfang {totalPerimetro:#.##} flächeninhalt {totalArea:#.##}";
        }
    }
}
