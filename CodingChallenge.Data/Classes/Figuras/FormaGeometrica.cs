using CodingChallenge.Data.Classes.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Figuras
{
    public class NombreFiguras
    {
        public string figura { get; set; }
        public string nombre { get; set; }
        public string nombrePlural { get; set; }
    }

    public abstract class FormaGeometrica
    {
        private string nombre;
        public FormaGeometrica(string nombre) 
        { 
            this.nombre = nombre;
        }


        public virtual decimal CalcularArea()
        {
            return 0;
        }
        public virtual decimal CalcularPerimetro()
        {
            return 0;
        }

        
        public string NombreFigura()
        {
            return nombre;
        }


    }
}
