using CodingChallenge.Data.Classes.Figuras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Idiomas.Idiomas
{
    public class Italiano : IIdioma
    {
        
        private readonly List<NombreFiguras> figuras;
        public Italiano()
        {
            figuras = new List<NombreFiguras>();
            figuras.Add(new NombreFiguras() { figura = "cuadrado", nombre = "quadrato", nombrePlural = "quadrati" });
            figuras.Add(new NombreFiguras() { figura = "rectangulo", nombre = "rettangolo", nombrePlural = "rettangoli" });
            figuras.Add(new NombreFiguras() { figura = "triangulo", nombre = "triangolo", nombrePlural = "triangoli" });
            figuras.Add(new NombreFiguras() { figura = "circulo", nombre = "cerchio", nombrePlural = "cerchi" });
            figuras.Add(new NombreFiguras() { figura = "trapecio", nombre = "trapezio", nombrePlural = "trapezi" });

        }

        public string ImprimirHeader()
        {
            return "<h1>Rapporto sulle forme</h1> ";
        }

        public string ImprimirLinea(int cantidad, decimal area, decimal perimetro, string nombreForma)
        {
            return $"{cantidad} {nombreForma} | area {area:#.##} | perimetro {perimetro:#.##} <br/>";
        }

        public string ImprimirListaVacia()
        {
            return "<h1>Elenco vuoto di forme!</h1>";
        }

        public string ImprimirNombreFigura(string figura)
        {
            var figura_find = figuras.Find(f => f.figura == figura);
            if (figura_find == null) throw new ArgumentOutOfRangeException(@"Forma sconosciuta");
            return figura_find.nombre;
        }

        public string ImprimirNombrePluralFigura(string figura)
        {
            var figura_find = figuras.Find(f => f.figura == figura);
            if (figura_find == null) throw new ArgumentOutOfRangeException(@"Forma sconosciuta");
            return figura_find.nombrePlural;
        }

        public string ImprimirTotal(int cantFormas, decimal totalPerimetro, decimal totalArea)
        {
            
            return $"Totale:<br/> {cantFormas} forme perimetro {totalPerimetro:#.##} area {totalArea:#.##}";
        }
    }
}
