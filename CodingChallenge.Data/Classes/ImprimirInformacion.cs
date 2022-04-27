using CodingChallenge.Data.Classes.Figuras;
using CodingChallenge.Data.Classes.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class ImprimirInformacion
    {

        public ImprimirInformacion() { }

        public static string Imprimir(List<FormaGeometrica> formas, IIdioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {

                sb.Append(idioma.ImprimirListaVacia());

            }
            else
            {
                // HEADER
                sb.Append(idioma.ImprimirHeader());

                var grupoFormas = formas.GroupBy(f => f.NombreFigura());

                foreach (var grupo in grupoFormas)
                {
                    var cantidad = grupo.Count();
                    var area = grupo.Sum(g => g.CalcularArea());
                    var perimetro = grupo.Sum(g => g.CalcularPerimetro());
                    var nombre = cantidad > 1 ? idioma.ImprimirNombrePluralFigura(grupo.Key) : idioma.ImprimirNombreFigura(grupo.Key);
                    sb.Append(idioma.ImprimirLinea(cantidad, area, perimetro, nombre));
                }


                // FOOTER
                sb.Append(idioma.ImprimirTotal(formas.Count(), formas.Sum(f => f.CalcularPerimetro()), formas.Sum(f => f.CalcularArea())));
            }

            return sb.ToString();
        }

        


    }
}
