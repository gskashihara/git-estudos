using Calculadora.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Divisao : IOperacao
    {
        public double Calculo(double valor1, double valor2)
        {
            if(valor2 == 0)
            {
                throw new DivideByZeroException("Você tentou fazer uma divisão por zero");
            }

            return valor1 / valor2;
        }
    }
}
