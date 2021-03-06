using CodingChallenge.Data.Classes.Figuras;
using CodingChallenge.Data.Classes.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        private readonly decimal lado;
        
        
        public Cuadrado(decimal lado) : base("cuadrado")
        {
            this.lado = lado;
            
        }

        public override decimal CalcularArea()
        {
            return lado * lado;
        }

        public override decimal CalcularPerimetro()
        {
            return lado * 4;
        }

        

    }
}
