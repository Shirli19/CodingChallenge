using CodingChallenge.Data.Classes.Figuras;
using CodingChallenge.Data.Classes.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal baseMayor;
        private readonly decimal baseMenor;
        private readonly decimal ladoIzq;
        private readonly decimal ladoDer;


        public Trapecio(decimal baseMayor, decimal baseMenor, decimal ladoIzq, decimal ladoDer): base("trapecio")
        {
            this.baseMayor = baseMayor;
            this.baseMenor = baseMenor;
            this.ladoIzq = ladoIzq;
            this.ladoDer = ladoDer;
            
        }
        public override decimal CalcularArea()
        {
            var altura = CalcularAltura();
            var mediana = (baseMayor + baseMenor) / 2;
            return mediana * altura;
        }

        public override decimal CalcularPerimetro()
        {
            return baseMayor + baseMenor + ladoIzq + ladoDer;
        }

        private decimal CalcularAltura()
        {
            var valor = Math.Pow(Decimal.ToDouble(ladoIzq), 2) 
                            - Math.Pow(Decimal.ToDouble(((ladoIzq * ladoIzq - ladoDer * ladoDer) + ((baseMayor - baseMenor)* 
                                        (baseMayor - baseMenor)))/ (2 * (baseMayor - baseMenor))), 2);
            return (decimal)Math.Sqrt(valor);
        }


    }
}
