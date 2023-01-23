using Calculadora.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Multiplicacao : IOperacao
    {
        public double Calculo(double valor1, double valor2)
        {
            return valor1 * valor2;
        }
    }
}
