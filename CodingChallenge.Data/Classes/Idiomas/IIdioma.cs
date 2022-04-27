using CodingChallenge.Data.Classes.Figuras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public interface IIdioma
    {
        string ImprimirNombreFigura(string figura);
        string ImprimirNombrePluralFigura(string figura);
        string ImprimirListaVacia();
        string ImprimirHeader();
        string ImprimirTotal(int cantFormas, decimal totalPerimetro, decimal totalArea);
        string ImprimirLinea(int cantidad, decimal area, decimal perimetro, string nombreForma);
    }
}
