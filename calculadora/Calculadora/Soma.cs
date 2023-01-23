using Calculadora.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Soma : Operacao
    {
        public virtual double Calculo(double valor1, double valor2)
        {
            return valor1 + valor2;
        }
    }
}
