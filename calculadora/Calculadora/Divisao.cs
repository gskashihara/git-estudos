using Calculadora.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Divisao : Operacao
    {
        public double Calculo(double valor1, double valor2)
        {
            try
            {
                return valor1 / valor2;
            }
            catch(Exception ex)
            {
                throw  new DivideByZeroException(ex + "Você tentou fazer uma divisão por zero");
            }
        }
    }
}
