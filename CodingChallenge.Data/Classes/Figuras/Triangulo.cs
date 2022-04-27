using CodingChallenge.Data.Classes.Figuras;
using CodingChallenge.Data.Classes.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{

    public class Triangulo : FormaGeometrica
    {
        private readonly decimal lado1;
        private readonly decimal lado2;
        private readonly decimal lado3;

        public Triangulo(decimal lado1, decimal lado2 = 0, decimal lado3 = 0): base("triangulo")
        {
            this.lado1 = lado1;
            this.lado2 = lado2 != 0 ? lado2 : lado1;
            this.lado3 = lado3 != 0 ? lado3 : lado1;

        }

        public override decimal CalcularArea()
        {
            var semiPerimetro = CalcularSemiPerimetro();
            var valor = semiPerimetro * (semiPerimetro - lado1) * (semiPerimetro - lado2) * (semiPerimetro - lado3);
            return (decimal)Math.Sqrt(Decimal.ToDouble(valor));
        }

        public override decimal CalcularPerimetro()
        {
            return (lado1 + lado2 + lado3);
        }

       
        private decimal CalcularSemiPerimetro()
        {
            return CalcularPerimetro() / 2;
        }
    }
}
